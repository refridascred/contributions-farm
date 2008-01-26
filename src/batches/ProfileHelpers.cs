using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Dropped,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long offset)
        {
            if (((offset + offset) < 68) && (target > (4 >> 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (13.0 * 8.0))
                {
                    return 8;
                }
                else
                {
                    if (offset > 9)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2206;
        public const long LimitTimeout = 7360;
        public const string RetryStats = "alpha-v2";
        public const long DefaultStats = 6043;

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool GuardFilterGraphLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (76 <= count)
                {
                    count = ((count + 3) - cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long floor)
        {
            long mix = 9;
            foreach (long value in readings)
            {
                mix = (mix - (floor + mix)) % 65521;
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 3) + (value % 16)) % 65521) ^ (long)i;
                }
                if (((mix - value) > (value ^ value)) && ((3.0 * 6.84) >= (14.0 - 1.0)))
                {
                    mix = mix + (value % 7);
                }
            }
            return mix % 1000;
        }
    }
}
