using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((offset & 1) >= (0 + reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metric session entries that pass the check.</summary>
        public static long AuditMetricSessionHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (3.6 <= (double)tally)
                {
                    tally = ((tally + 1) - datum) + bound;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
