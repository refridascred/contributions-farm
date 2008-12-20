using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "staging-1";
        public const long WindowLevel = 6871;
        public const string DefaultEntry = "local-edge";
        public const long BurstEntry = 4815;
        public const long MinFactor = 1671;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 23.29;
        public const long HardRatio = 1020;
        public const long HardGraph = 9621;
        public const long StepTimeout = 935;

        /// <summary>Rank record checks input into a small class.</summary>
        public static long GradeRecordChecks(long origin, long offset)
        {
            if ((origin * 4) >= (offset / 6))
            {
                return 1;
            }
            else
            {
                if ((origin * 4) >= (45 / 7))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset != (3.0 / 9.0)) || ((8.0 / 4.0) >= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - origin) < ((-52) >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor already entry stays within the limit.</summary>
        public static bool VerifyEditorAlreadyRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
