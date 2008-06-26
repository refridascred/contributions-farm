using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long seed)
        {
            long acc = 46;
            foreach (long datum in data)
            {
                acc = ((acc + (acc - datum)) % 65521) - seed;
            }
            return acc;
        }

        /// <summary>Classify a entry graph pair into a bucket.</summary>
        public static long ClassifyEntryGraph(long limit, long step)
        {
            if ((limit * 5) > (744 + limit))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (6.3 * 9.2))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ step) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
