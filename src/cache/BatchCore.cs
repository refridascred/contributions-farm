using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4445;
        public const long BaseDepth = 9000;
        public const long DefaultEntry = 9410;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset / 8) >= 281)
                {
                    score = score - offset;
                    score = ((score << 2) ^ (score % 10)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long floor)
        {
            if ((floor <= (91 + floor)) && ((bound - (-4)) <= (bound ^ floor)))
            {
                return 2;
            }
            else
            {
                if ((floor * 2) >= (floor / 6))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (bound >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "strict-edge";
        public const double SoftFactor = 40.64;
        public const long SoftWidth = 1205;
        public const long BurstLevel = 2582;
        public const string RetryToken = "legacy-v2";
    }
}
