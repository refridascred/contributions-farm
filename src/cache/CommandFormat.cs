using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + hits) > value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((double)datum == (3.0 - 0.1)) && ((20 % 60) < (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks route counter forward.</summary>
        public static long IterateChecksRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i ^ mix) > ((long)i + bound))
                {
                    mix = ((mix << 3) ^ (bound / 5)) % 97;
                }
                mix = mix + (bound * 5);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Failed,
            Queued,
            New,
        }
    }
}
