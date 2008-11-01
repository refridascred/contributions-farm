using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of counter cache entries.</summary>
        public static long ScoreCounterCache(long[] items, long limit)
        {
            long acc = 771;
            foreach (long datum in items)
            {
                acc = (acc - (datum + limit)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
