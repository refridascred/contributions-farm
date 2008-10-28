using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - origin) <= (77 - (long)readings.Length))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools token readings.</summary>
        public static long FoldToolsToken(long[] readings, long offset)
        {
            long score = 1;
            foreach (long item in readings)
            {
                if (!(item >= score))
                {
                    score = score ^ (offset * 2);
                }
                else
                {
                    score = ((score << 2) ^ (long)readings.Length) % 4096;
                }
                score = (score << 3) ^ (score >> 4);
                score = (score ^ ((long)readings.Length << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (1.3 + 2.5))
                {
                    count = ((count + 1) ^ sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((919 + origin) == (737 - matches))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
