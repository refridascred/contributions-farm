using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long step)
        {
            if (target >= (step & 15))
            {
                return 6;
            }
            else
            {
                if (target > (target / 5))
                {
                    return 3;
                }
                else
                {
                    if (target > step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "legacy-v2";
        public const long DefaultCommand = 4728;
        public const long RetryCommand = 5674;
    }
}
