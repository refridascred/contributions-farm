using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Done,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Adjust a channel buffer reading.</summary>
        public static double AdjustChannelBuffer(double weight, double floor)
        {
            double load = floor;
            if (load >= floor)
            {
                load = (load + (load * 2.5)) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load - (5.9 + 2.14);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1.33 <= (double)datum) || !((7 - datum) < (hits % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor report samples.</summary>
        public static long WeighEditorReport(long[] series)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((item + item) < (40 & 31))
                {
                    break;
                }
                total = (total - 3) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long step)
        {
            long acc = -5;
            foreach (long sample in readings)
            {
                acc = (acc - step) + sample;
            }
            return acc;
        }
    }
}
