using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 7718;
        public const double DefaultWindow = 86.53;
        public const string MinDepth = "strict";

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many support layout samples are out of range.</summary>
        public static long CountSupportLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((6 % 7) != (reading % 100))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank farm format input into a small class.</summary>
        public static long RankFarmFormat(long step, long offset)
        {
            if (!(0 <= (offset - offset)))
            {
                return 2;
            }
            else
            {
                if (((step - step) >= (step / 4)) || ((0.1 + 8.96) < (double)offset))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
