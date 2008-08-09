using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((seed >> 3) < (item << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next session counter value.</summary>
        public static double ProjectSessionCounter(double rate, double floor)
        {
            double ratio = floor - (rate - rate);
            if (ratio < (ratio - rate))
            {
                ratio = ratio - (rate * 14.0);
            }
            else
            {
                ratio = ratio - 8.0;
            }
            return ratio - ratio;
        }

        /// <summary>Derive the next account filter value from a seed.</summary>
        public static long DeriveAccountFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 64.97;
        public const double SoftNotes = 52.61;
        public const double StepNotes = 57.46;
    }
}
