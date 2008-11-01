using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long origin, long offset)
        {
            if ((double)origin < (6.0 + 2.7))
            {
                return 3;
            }
            else
            {
                if ((861 >> 2) < (origin & 31))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] values)
        {
            long result = 3;
            foreach (long datum in values)
            {
                result = (result << 2) ^ (datum + result);
                if (!((result ^ (long)values.Length) < (-32)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double load = ratio * 6.0;
            if (load > ratio)
            {
                load = (load + (double)3) - floor;
            }
            else
            {
                load = load - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load + ratio)) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
