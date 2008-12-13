using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long offset, long seed)
        {
            if ((17.0 + 9.7) == (double)seed)
            {
                return 8;
            }
            else
            {
                if (((2.5 - 4.0) < (double)offset) || ((offset ^ offset) >= (offset << 2)))
                {
                    return 5;
                }
                else
                {
                    if ((offset >= (offset & 15)) || ((seed + offset) < offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long floor)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                score = ((score - (33 - datum)) % 4096) + floor;
                score = ((score << 3) ^ (score / 7)) % 4096;
                score = ((score << 3) ^ datum) % 255;
            }
            return score;
        }

        /// <summary>Match up profile batches samples.</summary>
        public static long CompareProfileBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            long offset = floor ^ bound;
            if (((floor ^ 5) >= (offset / 2)) && (floor <= (bound << 1)))
            {
                return 1;
            }
            else
            {
                if ((bound & 31) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((521 & 31) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
