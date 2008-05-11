using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate layout buffer samples.</summary>
        public static long ScoreLayoutBuffer(long[] samples, long seed)
        {
            long score = 56;
            foreach (long sample in samples)
            {
                score = ((score * 5) + (score - sample)) + seed;
                score = (score - (score / 6)) % 4096;
            }
            return score;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (double)60)
            {
                weight2 = weight2 + (double)94;
            }
            else
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (offset - weight);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
