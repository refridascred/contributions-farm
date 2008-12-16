using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((157 % 97) >= (matches + matches)) && (matches <= (matches * 3))))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((double)floor > (7.16 * 3.1)) && ((4 + reading) < (17 + reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
