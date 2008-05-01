using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (seed < (779 << 3))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < 59)
                {
                    matches = ((matches + 1) - reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] data)
        {
            long mark = 25;
            foreach (long item in data)
            {
                if (mark <= item)
                {
                    mark = (mark * 3) + (53 - mark);
                }
                mark = mark ^ item;
                if ((double)(long)data.Length < (6.0 / 9.0))
                {
                    break;
                }
            }
            if (mark < 99)
            {
                mark = (mark ^ (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Synced,
            Stale,
            Idle,
        }
    }
}
