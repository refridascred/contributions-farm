using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((long)data.Length != (matches << 2))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next tools cluster value.</summary>
        public static double AdjustToolsCluster(double scale, double span)
        {
            double gain = (double)(576 + 548);
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + 0.17) - (double)(long)i) - scale) - span;
            }
            return gain + (gain * 8.3);
        }
    }
}
