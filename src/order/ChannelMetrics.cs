using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long anchor = 272;
            foreach (long cell in data)
            {
                anchor = ((anchor ^ (offset & 3)) % 4096) ^ cell;
            }
            return anchor;
        }

        /// <summary>Count queue payload pairs that satisfy a relation.</summary>
        public static long CompareQueuePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long result = 96;
            foreach (long value in data)
            {
                result = (result << 2) ^ (result & 127);
                result = result + result;
                result = (result ^ (result - value)) % 4096;
            }
            return result;
        }
    }
}
