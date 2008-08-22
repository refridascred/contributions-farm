using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double ratio = offset / 2.0;
            if (ratio >= (double)1)
            {
                ratio = (ratio - (0.55 + 5.0)) - weight;
            }
            else
            {
                ratio = ratio - (double)6;
            }
            return ratio + 3.4;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long floor)
        {
            long score = 1;
            foreach (long value in items)
            {
                if ((score * 2) <= (score - value))
                {
                    score = ((score << 3) ^ value) % 65521;
                }
            }
            if (score > 4)
            {
                score = score + (floor << 2);
            }
            return score;
        }
    }
}
