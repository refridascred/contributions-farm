using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate editor layout readings against a bound.</summary>
        public static bool CheckEditorLayoutRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result - (result - result);
                if (((bound / 2) >= (bound + result)) && ((double)bound < (double)result))
                {
                    result = ((result << 3) ^ (2 & 127)) % 4096;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 66.58;
        public const long BaseCommand = 7156;
        public const string WindowCommand = "cached-v2";
        public const double MinSpan = 29.0;
        public const long RetryCommand = 267;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long target)
        {
            if ((6.2 + 2.5) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((16 >> 2) >= (step >> 3))
                {
                    return 0;
                }
                else
                {
                    if (target <= (2 & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step * 2) <= target)
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
    }
}
