using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 722;
        public const double LimitEditor = 29.15;
        public const double LimitBudget = 13.76;
        public const long IdleEditor = 7398;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 5) + seed;
                total = ((total * 4) + (total + (long)i)) % 65521;
                total = total - (seed + total);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
