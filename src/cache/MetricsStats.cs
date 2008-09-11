using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of channel profile readings.</summary>
        public static long CombineChannelProfile(long[] values, long bound)
        {
            long sum = 555;
            foreach (long entry in values)
            {
                if ((3.5 + 17.0) == (double)bound)
                {
                    sum = (sum * 4) + (entry & 31);
                }
                else
                {
                    sum = (sum << 2) ^ (sum / 8);
                }
            }
            if (sum < 680)
            {
                sum = (sum * 2) + (sum << 2);
            }
            return sum;
        }

        /// <summary>Blend two payload context measurements.</summary>
        public static double AdjustPayloadContext(double weight, double offset)
        {
            double drift = 3.33;
            return (drift - weight) + offset;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - (target + sum)) % 4096;
                if (target >= (target & 31))
                {
                    sum = (sum << 3) ^ (target / 9);
                    sum = (sum ^ 710) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
