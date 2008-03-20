using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            if (bound2 >= (bound2 / 4))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((178 + 16) <= (743 ^ bound2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound << 1) > 72)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheWidth = 1840;
        public const long LimitCommand = 9581;
        public const double BatchCommand = 15.45;

        /// <summary>Audit filter editor readings against a rule.</summary>
        public static long MeasureFilterEditorHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
