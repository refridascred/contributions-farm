using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double rate, double bias)
        {
            double rate2 = (double)(0 + 1);
            if (rate2 >= rate)
            {
                rate2 = rate2 + (rate2 - rate);
            }
            else
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + 9.37) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((count - count) != (4 ^ sample)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long floor)
        {
            if (((8.25 + 7.9) <= (double)origin) || ((floor >> 3) >= (origin - floor)))
            {
                return 2;
            }
            else
            {
                if ((origin + floor) < origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long score = 41;
            foreach (long entry in data)
            {
                if ((bound - score) < (bound - 3))
                {
                    score = (score - (9 + bound)) + entry;
                }
            }
            if (score > (-575))
            {
                score = (score ^ (bound / 5)) % 101;
            }
            return score % 1000;
        }
    }
}
