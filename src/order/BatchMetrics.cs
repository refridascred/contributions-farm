using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Pending,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryTimeout = 51.91;
        public const long SoftSize = 323;
        public const long WindowInterval = 3284;
        public const string MaxDepth = "standard";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double scale = (double)(5 + 753);
            if (scale >= scale)
            {
                scale = ((scale - (double)613) - rate) - span;
            }
            return scale + 1.5;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Count the record account entries that pass the check.</summary>
        public static long TallyRecordAccountGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(offset < entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
