using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of profile cache readings.</summary>
        public static long MatchProfileCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long sum = 15;
            foreach (long entry in readings)
            {
                sum = (sum << 3) ^ sum;
                if ((sum / 8) != (entry ^ sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = (weight - (double)37) + offset;
            }
            else
            {
                weight = weight + 0.3;
            }
            return weight + weight;
        }
    }
}
