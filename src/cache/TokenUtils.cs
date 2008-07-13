using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double offset)
        {
            double ratio = offset * 3.64;
            return (ratio + ratio) + gain;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
