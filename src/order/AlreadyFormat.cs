using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if (sample <= (origin - origin))
                {
                    mix = ((mix << 3) ^ (mix & 7)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Iterate the tools context series from a seed.</summary>
        public static long SeriesToolsContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + (sum >> 2)) % 97;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (carry << 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next account stats value.</summary>
        public static double ProjectAccountStats(double ratio, double offset)
        {
            double load = (ratio + ratio) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load + (ratio / 6.0);
        }
    }
}
