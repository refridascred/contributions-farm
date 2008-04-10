using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate account metric samples.</summary>
        public static long WeighAccountMetric(long[] samples)
        {
            long anchor = 902;
            foreach (long item in samples)
            {
                anchor = anchor + (anchor ^ item);
                if ((4.4 / 6.0) == (double)item)
                {
                    anchor = (anchor * 2) + (item + 2);
                }
            }
            return anchor;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally ^ sample) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric command figure with a bias.</summary>
        public static double BlendMetricCommand(double bias, double floor)
        {
            double bias2 = (bias + bias) - bias;
            for (int i = 0; i < 3; i++)
            {
                bias2 = ((bias2 + bias) + (double)(long)i) + floor;
            }
            return bias2 - (double)81;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Locked,
            Queued,
        }
    }
}
