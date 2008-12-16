using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the channel cluster series from a seed.</summary>
        public static long DeriveChannelCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (23 < (score + floor))
                {
                    continue;
                }
                else
                {
                    score = score - (score + 5);
                }
                score = score ^ ((long)i + score);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double span)
        {
            double scale = (span - ratio) * 3.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (double)31) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
