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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long seed)
        {
            if ((double)step != (6.3 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((step * 2) > (seed * 5))
                {
                    return 2;
                }
                else
                {
                    if (step >= (step / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
