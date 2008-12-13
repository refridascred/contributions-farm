using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (6.55 + 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream metric readings.</summary>
        public static long TallyStreamMetric(long[] values, long limit)
        {
            long anchor = 803;
            foreach (long reading in values)
            {
                anchor = (((anchor ^ (1 / 7)) % 101) + reading) - limit;
                if (!((double)anchor <= (4.0 + 7.7)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count / 6) != (5 + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
