using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank checks already input into a small class.</summary>
        public static long SortChecksAlready(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((edge >> 5) != (edge * 2))
            {
                return 6;
            }
            else
            {
                if (!(edge < (limit - limit2)))
                {
                    return 3;
                }
                else
                {
                    if (184 < (limit2 + limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - limit2) >= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Match up already notes samples.</summary>
        public static long MatchAlreadyNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)(-4) == (double)tally)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
