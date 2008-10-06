using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((limit - value) >= (tally / 3)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values, long floor)
        {
            long mix = -58;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix << 2) ^ (993 + floor);
                    mix = mix ^ (long)i;
                }
                mix = (mix - entry) % 1000;
                if ((8.9 / 5.0) <= (double)mix)
                {
                    mix = (mix ^ (mix - entry)) % 255;
                }
                if ((floor >= 87) && ((double)400 == (double)floor))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultInterval = "standard-edge";
        public const long MaxDepth = 784;
        public const double MinBudget = 64.81;
        public const long DefaultLevel = 3932;
    }
}
