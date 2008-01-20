using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstInterval = 9550;
        public const double BurstAccount = 41.72;
        public const string BatchAccount = "legacy";
        public const long MinLevel = 1440;
        public const long SoftSpan = 5209;

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 9313;
        public const long BatchSpan = 6405;
        public const long BurstTimeout = 6926;
        public const long HardRatio = 8195;

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long step)
        {
            long edge = target ^ step;
            if ((edge * 3) > target)
            {
                return 5;
            }
            else
            {
                if (((3.99 / 5.0) != (double)target) && ((double)step <= (8.5 - 0.5)))
                {
                    return 3;
                }
                else
                {
                    if ((edge + target) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((97 & 15) != (step ^ step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
