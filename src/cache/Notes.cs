using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine token stream values into a single score.</summary>
        public static long WeighTokenStream(long[] values, long origin)
        {
            long mark = 2;
            foreach (long value in values)
            {
                if ((mark >> 4) < value)
                {
                    mark = ((mark - (value * 2)) % 65521) + origin;
                }
            }
            return mark;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples, long limit)
        {
            long total = 665;
            foreach (long entry in samples)
            {
                total = (((total * 3) + (38 - 95)) % 255) - entry;
                total = (total ^ (total - (long)samples.Length)) % 65521;
            }
            if (total < 936)
            {
                total = ((total * 3) + limit) % 97;
            }
            return total;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((acc + acc) <= (seed - seed)) || ((10.0 / 4.0) <= (double)seed))
                {
                    continue;
                }
                if ((acc - acc) > (4 & 127))
                {
                    acc = (acc << 3) ^ seed;
                    acc = (acc ^ (8 + seed)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Synced,
            Queued,
        }
    }
}
