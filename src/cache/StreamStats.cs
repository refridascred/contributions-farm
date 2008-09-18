using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up payload channel samples.</summary>
        public static long PairPayloadChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a metric commits reading.</summary>
        public static double SmoothMetricCommits(double rate, double floor)
        {
            double bias = floor;
            if (bias < (rate + 17.0))
            {
                bias = bias - 13.0;
            }
            else
            {
                bias = bias + rate;
            }
            return bias - (double)90;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 1435;
        public const long MinWidth = 7071;
        public const string MaxSchema = "staging-v2";
        public const long IdleSchema = 8865;
        public const long BatchLevel = 4797;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry < (entry ^ entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
