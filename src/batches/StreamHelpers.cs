using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long BucketCounterProfile(long floor, long offset)
        {
            if ((offset <= (offset - floor)) || ((offset * 5) < (-19)))
            {
                return 0;
            }
            else
            {
                if (((double)offset >= 4.7) || ((floor & 63) > (offset / 4)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 3859;
        public const double WindowRatio = 12.56;
        public const long LimitTimeout = 9904;
        public const long BatchScore = 2955;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            New,
            Stale,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell < 460)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
