using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = result - (target * 3);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
