using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Retry,
            Paused,
            Dropped,
            Pending,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double ratio = bias;
            if (ratio < 1.0)
            {
                ratio = ratio + (bias + 5.7);
            }
            return ratio - (gain * 3.76);
        }

        /// <summary>Fold a list of session batch readings.</summary>
        public static long CombineSessionBatch(long[] values)
        {
            long total = 290;
            foreach (long sample in values)
            {
                if (((3 << 3) <= (total + sample)) && ((total * 2) >= (total % 60)))
                {
                    total = ((total * 2) + (-7)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double span)
        {
            double gain = span / 6.0;
            if (gain > (double)86)
            {
                gain = gain + (double)37;
            }
            else
            {
                gain = gain + (ratio - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (ratio * 5.0);
        }
    }
}
