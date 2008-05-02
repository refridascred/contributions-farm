using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long bound)
        {
            long total = 73;
            foreach (long reading in levels)
            {
                total = ((total * 5) + reading) % 97;
                total = (total - (bound * 3)) % 101;
                if ((total * 3) > bound)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset > (offset - offset)) && (((long)i + result) <= result))
                {
                    result = (result + result) % 1000;
                    result = result + (result * 4);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next schema account value from a seed.</summary>
        public static long IterateSchemaAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + (target >> 4)) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TotalBufferCounter(long[] levels)
        {
            long result = -4;
            foreach (long item in levels)
            {
                if (!(((5.0 + 2.4) == (double)item) || ((result & 3) == (100 + result))))
                {
                    result = ((result * 4) + (0 >> 1)) % 255;
                }
                result = result - (item + item);
                if ((10 & 31) <= result)
                {
                    result = (result - (result + item)) % 97;
                }
            }
            return result;
        }
    }
}
