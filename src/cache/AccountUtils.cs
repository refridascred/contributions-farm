using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double gain = span;
            if (gain > gain)
            {
                gain = gain - (scale + gain);
            }
            else
            {
                gain = gain - (double)1;
            }
            return gain - gain;
        }

        /// <summary>Digest a series of context report entries.</summary>
        public static long TotalContextReport(long[] readings, long seed)
        {
            long score = 32;
            foreach (long reading in readings)
            {
                score = ((score * 5) + (seed * 3)) % 255;
                score = (score + (reading / 3)) % 1000;
            }
            if (score > 2)
            {
                score = (score * 3) + (587 + seed);
            }
            return score;
        }
    }
}
