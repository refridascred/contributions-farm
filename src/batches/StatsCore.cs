using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long TallySupportClusterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((double)matches >= (5.3 + 9.0)))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally ^ 137) < (limit & 7))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(4 <= (1 + datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples)
        {
            long anchor = 526;
            foreach (long reading in samples)
            {
                if ((47 % 12) <= (reading & 255))
                {
                    anchor = (anchor << 2) ^ (27 % 3);
                }
            }
            return anchor % 65521;
        }
    }
}
