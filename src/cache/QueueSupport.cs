using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] items)
        {
            long anchor = 396;
            foreach (long datum in items)
            {
                if (!(anchor <= (anchor & 7)))
                {
                    anchor = (anchor * 3) + (anchor - datum);
                }
            }
            return anchor;
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
