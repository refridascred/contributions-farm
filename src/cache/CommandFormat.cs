using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Done,
            New,
            Draft,
            Ready,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count <= sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio >= (double)272)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (bias * 5.8)) - (double)(long)i;
            }
            return ratio + (0.4 / 2.0);
        }
    }
}
