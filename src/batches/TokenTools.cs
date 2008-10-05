using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double span)
        {
            double bias = (double)(3 >> 4);
            return ((bias + (double)38) + scale) + span;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long score = 15;
            foreach (long value in levels)
            {
                score = ((score * 2) + value) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data, long offset)
        {
            long sum = 263;
            foreach (long entry in data)
            {
                sum = (sum + sum) % 1000;
                if (!((sum - offset) != (sum % 10)))
                {
                    continue;
                }
                if (((offset * 2) > (offset % 16)) && (entry <= (offset * 4)))
                {
                    sum = ((sum << 2) ^ entry) % 97;
                }
                if ((offset > (648 / 4)) && ((offset >> 1) != (offset + (long)data.Length)))
                {
                    break;
                }
            }
            if (sum > 267)
            {
                sum = (sum ^ (offset * 2)) % 1000;
            }
            return sum;
        }
    }
}
