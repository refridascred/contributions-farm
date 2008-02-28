using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally / 2) != (tally << 2))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes command samples are out of range.</summary>
        public static long MeasureNotesCommandHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((5 ^ seen) <= (reading << 3))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long limit)
        {
            long slot = target + limit;
            if (limit >= (slot & 1))
            {
                return 6;
            }
            else
            {
                if ((slot + limit) <= (slot + target))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Paused,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((15.0 * 5.49) != (double)hits)
                {
                    hits = ((hits + 2) + reading) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
