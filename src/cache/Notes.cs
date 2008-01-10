using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches & 255) < (-7)) || ((double)datum > 8.0))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long limit)
        {
            long gap = target - limit;
            if ((target + limit) <= (target / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)gap > (3.5 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.54 + 0.4) >= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target >= (4.3 / 9.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
