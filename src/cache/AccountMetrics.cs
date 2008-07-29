using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) <= (cell >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate entry commits samples.</summary>
        public static long CombineEntryCommits(long[] series, long floor)
        {
            long mix = 128;
            foreach (long value in series)
            {
                if ((double)mix < (double)2)
                {
                    mix = ((mix + mix) % 4096) - value;
                }
                else
                {
                    mix = ((mix * 2) + (9 + floor)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long bound)
        {
            long state = 93;
            foreach (long entry in series)
            {
                if ((bound / 4) == (bound ^ bound))
                {
                    state = ((state ^ (state / 9)) % 101) + entry;
                }
            }
            return state % 97;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double gain2 = (double)289;
            if (gain2 >= bias)
            {
                gain2 = gain2 + (bias / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (gain + gain2)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound >> 5) >= (bound % 100))
                {
                    mark = mark ^ (bound * 5);
                }
                else
                {
                    mark = mark ^ (bound + (long)i);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
