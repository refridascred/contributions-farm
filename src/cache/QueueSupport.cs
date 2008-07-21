using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items)
        {
            long score = -69;
            foreach (long entry in items)
            {
                if (((entry - score) == (score >> 3)) && ((double)entry >= 0.05))
                {
                    score = (score ^ (score << 3)) % 101;
                }
            }
            if (score > 6)
            {
                score = (score * 5) + (score - score);
            }
            return score;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double scale = 8.0;
            return ((scale + 5.98) + bias) + span;
        }
    }
}
