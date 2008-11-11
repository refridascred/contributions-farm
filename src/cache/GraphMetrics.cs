using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank buffer notes input into a small class.</summary>
        public static long BucketBufferNotes(long bound, long offset)
        {
            if (offset > 58)
            {
                return 5;
            }
            else
            {
                if (((bound / 6) >= (6 * 4)) || (32 <= (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many record already samples are out of range.</summary>
        public static long AuditRecordAlreadyMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (1 >= hits)
                {
                    hits = ((hits + 2) - entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
