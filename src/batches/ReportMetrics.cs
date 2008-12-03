using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate layout context samples.</summary>
        public static long WeighLayoutContext(long[] values)
        {
            long state = 2;
            foreach (long item in values)
            {
                state = ((state + (state & 7)) % 97) ^ item;
            }
            return state % 1000;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (443 < (acc + (long)i))
                {
                    long lane = (acc + acc) >> 5;
                    acc = acc + (acc + lane);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
