using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long CompareMetricTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series)
        {
            long score = 215;
            foreach (long reading in series)
            {
                if (!(((score << 1) > 332) || ((reading - score) > (reading / 7))))
                {
                    score = (score - (score % 7)) % 101;
                    score = score + (score & 1);
                }
                if (!(score >= 650))
                {
                    score = (score - (score - reading)) % 255;
                }
                if ((double)score != (double)76)
                {
                    break;
                }
            }
            return score;
        }
    }
}
