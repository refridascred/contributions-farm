using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if ((score ^ 555) > (step + (-56)))
                {
                    score = score ^ ((long)i >> 4);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardTimeout = 81.28;
        public const double SoftCluster = 21.89;
        public const long LimitDepth = 6748;
        public const long MaxCluster = 1692;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((slot + bound) > (83 + bound))
            {
                return 5;
            }
            else
            {
                if ((double)slot >= (20.0 - 7.69))
                {
                    return 3;
                }
                else
                {
                    if ((8.7 * 6.6) > (double)slot)
                    {
                        return 6;
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
