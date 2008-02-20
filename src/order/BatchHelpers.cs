using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 2430;
        public const double DefaultTools = 4.55;
        public const long BatchInterval = 6480;
        public const string DefaultSize = "staging-v2";
        public const long MinTools = 9231;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long step)
        {
            if ((step >> 3) <= (bound ^ 40))
            {
                return 4;
            }
            else
            {
                if ((step >> 1) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (36 > (step - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step << 2) >= 6)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
