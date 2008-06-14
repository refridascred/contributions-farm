using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 65.99;
        public const string CacheDepth = "cached-v2";
        public const long RetryOrder = 4098;
        public const long BurstOrder = 2791;

        /// <summary>Find the first entry order entry that matches the target.</summary>
        public static long LocateEntryOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 95.56;
        public const double CacheCount = 76.88;
        public const double BaseBuffer = 30.06;
        public const string StepTimeout = "cached-v2";
        public const double CacheBuffer = 17.08;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)979)
            {
                weight = weight - (8.0 * 18.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (span - 1.12);
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((4.2 + 2.7) < (double)seen) && ((double)seen > (1.71 * 6.0))))
                {
                    seen = ((seen + 1) ^ reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
