using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if (((acc & 15) > (9 / 6)) || (sample <= (sample << 1)))
                {
                    acc = (acc << 3) ^ (sample - acc);
                }
                if ((sample + acc) == (acc >> 2))
                {
                    break;
                }
            }
            if (acc > 886)
            {
                acc = (acc - (acc >> 3)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
