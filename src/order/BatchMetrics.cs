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

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = total ^ (step + 18);
                total = (total << 2) ^ (total << 2);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
