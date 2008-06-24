using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleCount = 8022;
        public const string IdleEntry = "latest-v2";
        public const long StepEntry = 9917;

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double bias = 7.9;
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + weight;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Pending,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((866 + step) >= (step % 10)))
                {
                    carry = ((carry << 2) ^ (carry + step)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a command tools figure with a bias.</summary>
        public static double ScaleCommandTools(double bias, double floor)
        {
            double load = bias / 4.0;
            if (load < bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - floor;
            }
            return load + load;
        }
    }
}
