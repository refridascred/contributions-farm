using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] items, long step)
        {
            long score = 53;
            foreach (long item in items)
            {
                score = (((score * 4) + step) % 101) + item;
                if (!((4.22 + 9.0) > (double)score))
                {
                    score = (score - (step + step)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Locate a token counter reading by value.</summary>
        public static long SeekTokenCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
