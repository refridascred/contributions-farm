using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((7 % 2) < ((long)series.Length - datum)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double rate2 = 9.2;
            if (rate2 < (double)1)
            {
                rate2 = (rate2 + (double)7) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (span - rate2)) + (double)(long)i;
            }
            return rate2 + (double)82;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if (((offset + offset) <= (target % 97)) && (offset >= 89))
            {
                return 8;
            }
            else
            {
                if (((offset + 110) <= (offset * 3)) && ((13.0 * 6.52) <= (double)target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
