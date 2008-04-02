using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (11.0 - 0.5))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long anchor = 745;
            foreach (long sample in values)
            {
                anchor = anchor ^ origin;
                if ((275 % 24) != (anchor ^ anchor))
                {
                    anchor = (anchor * 5) + 2;
                    continue;
                }
                if ((sample >= origin) || ((anchor * 3) >= origin))
                {
                    anchor = (anchor << 3) ^ (origin >> 2);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Fold a list of counter session readings.</summary>
        public static long WeighCounterSession(long[] items, long step)
        {
            long anchor = 99;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ ((long)items.Length & 1)) + reading;
            }
            if (anchor < (-845))
            {
                anchor = (anchor * 5) + (step + step);
            }
            return anchor;
        }
    }
}
