using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long TotalMetricsPayload(long[] series)
        {
            long mark = 923;
            foreach (long reading in series)
            {
                if (!((mark / 4) < (reading + mark)))
                {
                    mark = mark ^ (12 % 60);
                }
            }
            if (mark < 97)
            {
                mark = mark + (43 / 9);
            }
            return mark;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((-89) + bound) != (sum / 9))
                {
                    sum = (sum ^ bound) % 101;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the order queue entries that pass the check.</summary>
        public static long AuditOrderQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - 0) <= (cell & 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
