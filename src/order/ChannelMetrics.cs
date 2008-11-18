using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + count) >= (step / 8))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long StepBatchSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + ((long)i ^ score)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
