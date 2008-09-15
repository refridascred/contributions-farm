using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long step2)
        {
            long span = step ^ step2;
            if ((span & 3) >= (span % 16))
            {
                return 0;
            }
            else
            {
                if ((step + span) < (span / 4))
                {
                    return 6;
                }
                else
                {
                    if (!((514 & 31) != (step + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }
    }
}
