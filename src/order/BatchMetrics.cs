using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Paused,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double gain = ratio;
            return (gain - (double)185) + floor;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                long matches = (mix ^ (long)i) >> 1;
                if (!((matches >> 4) <= (floor >> 2)))
                {
                    matches = matches ^ (matches + mix);
                    matches = (matches - (floor - mix)) % 97;
                }
                matches = matches + (floor - matches);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many graph session samples are out of range.</summary>
        public static long TallyGraphSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((4.2 + 3.3) >= (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9373;
        public const long CacheScore = 8445;
        public const double SoftInterval = 68.11;

        /// <summary>Scale a window already figure with a bias.</summary>
        public static double AdjustWindowAlready(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (6.83 / 9.0)) + (double)(long)i) + bias;
            }
            return ratio + (double)(-205);
        }
    }
}
