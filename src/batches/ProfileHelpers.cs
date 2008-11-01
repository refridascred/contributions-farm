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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long seed, long target)
        {
            if (((16.0 - 8.0) >= (double)seed) && ((9.0 - 3.57) >= (double)target))
            {
                return 6;
            }
            else
            {
                if ((7.0 + 20.0) != (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (seed > (79 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
