using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "fallback";
        public const long StepReport = 4323;
        public const double DefaultReport = 14.23;

        /// <summary>Rank account editor input into a small class.</summary>
        public static long BucketAccountEditor(long bound, long seed)
        {
            if ((25 / 4) >= (seed << 1))
            {
                return 5;
            }
            else
            {
                if ((2.9 + 7.9) > (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((bound & 31) >= 4) && ((seed << 1) <= (-8)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
