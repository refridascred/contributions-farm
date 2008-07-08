using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < (ratio + bias))
            {
                ratio2 = ratio2 - 6.38;
            }
            return ratio2 + bias;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values)
        {
            long score = 1;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (score << 1)) % 97;
                score = score + (0 ^ reading);
            }
            if (score < 7)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
