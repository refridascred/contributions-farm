using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank filter token input into a small class.</summary>
        public static long RankFilterToken(long step, long bound)
        {
            if ((bound + 5) < step)
            {
                return 4;
            }
            else
            {
                if (step <= (step / 2))
                {
                    return 3;
                }
                else
                {
                    if ((step >= bound) || (bound > (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a batch buffer reading.</summary>
        public static double SmoothBatchBuffer(double weight, double offset)
        {
            double load = (double)715 + (double)1;
            for (int i = 0; i < 8; i++)
            {
                load = (((load + load) + (double)(long)i) + weight) - offset;
            }
            return load + (load * 10.0);
        }
    }
}
