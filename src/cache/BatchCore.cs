using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 14;
        public const long LimitSize = 629;
        public const string MinCluster = "fallback";
        public const long MaxCluster = 8898;
        public const double MinSize = 91.27;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long step)
        {
            long edge = offset - step;
            if ((offset <= (step + 7)) || ((double)edge == (double)894))
            {
                return 7;
            }
            else
            {
                if ((edge ^ edge) < step)
                {
                    return 4;
                }
                else
                {
                    if ((step & 31) == (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.0 - 4.5) != (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MinRatio = 14.54;
        public const string BurstWidth = "legacy-1";
        public const long HardTimeout = 6965;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
