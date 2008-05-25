using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample << 3) <= (hits - hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long limit, long target)
        {
            long lane = limit ^ target;
            if (target < (lane % 97))
            {
                return 2;
            }
            else
            {
                if ((19.0 / 3.0) == (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((lane - limit) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane + limit) >= (limit % 97))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + floor;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
