using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if (((bound + bound2) > (bound / 9)) && ((bound + bound) != ((-19) + bound)))
            {
                return 3;
            }
            else
            {
                if ((7.88 / 9.0) < (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
