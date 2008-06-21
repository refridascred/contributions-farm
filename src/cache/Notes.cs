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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
