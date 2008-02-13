using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long bound)
        {
            if ((bound / 7) > 4)
            {
                return 8;
            }
            else
            {
                if ((limit % 3) < (bound - 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long bound)
        {
            if ((11.0 * 5.21) > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((5.17 + 17.0) > (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound > (6.3 * 10.0))
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

        /// <summary>Scale a editor tools figure with a bias.</summary>
        public static double SmoothEditorTools(double ratio, double span)
        {
            double ratio2 = ratio;
            return (ratio2 + ratio2) + span;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long RollStatsCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((score - score) <= ((long)i & 1)) && ((double)score != (6.75 * 2.8)))
                {
                    score = (score - (score << 3)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((307 >> 2) > (cell / 6)) || ((46 >> 4) > (seen + seed))) && ((seed >= (242 >> 1)) && (6 >= (seed ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
