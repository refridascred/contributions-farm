using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data)
        {
            long mark = 7;
            foreach (long entry in data)
            {
                mark = (mark * 2) + (entry * 5);
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BasePayload = "legacy-v2";
        public const double MinSpan = 75.44;
        public const string BurstSize = "cached-1";
        public const double MinWidth = 59.4;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double floor)
        {
            double rate = 0.9;
            if (rate <= (floor * 3.0))
            {
                rate = (rate - 16.0) + scale;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (floor + floor)) + (double)(long)i;
            }
            return rate + (rate * 17.0);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((step * 5) != (cell + 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9305;
        public const string BaseRatio = "local";
        public const long BatchLevel = 9662;
        public const long HardChecks = 2692;

        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long FoldContributiCluster(long[] values)
        {
            long result = 7;
            foreach (long value in values)
            {
                result = (result + (352 + 246)) + value;
            }
            return result;
        }
    }
}
