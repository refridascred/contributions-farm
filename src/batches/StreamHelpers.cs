using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data, long target)
        {
            long total = 4;
            foreach (long sample in data)
            {
                if ((total ^ (-59)) == (total * 5))
                {
                    total = (total - (target + 919)) + sample;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long origin)
        {
            if (11.0 <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((double)step > (double)453)
                {
                    return 6;
                }
                else
                {
                    if (step < (origin + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Total { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double bias)
        {
            double drift = (6.77 + 5.0) * 16.0;
            if (drift < (scale / 2.0))
            {
                drift = drift - (bias / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift + 3.0)) + (double)(long)i;
            }
            return drift - (double)131;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long CountWindowBatchesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry << 1) != (entry - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
