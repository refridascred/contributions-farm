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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Queued,
            New,
            Synced,
            Locked,
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
