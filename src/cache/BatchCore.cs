using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of contributi token readings.</summary>
        public static long PairContributiTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long target, long target2)
        {
            long slot = target - target2;
            if ((double)target != (double)slot)
            {
                return 1;
            }
            else
            {
                if (target >= (target2 - target2))
                {
                    return 0;
                }
                else
                {
                    if ((13 - 6) != (slot + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 / 2.0) >= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((7.8 + 9.02) == (double)result)
                {
                    result = result - (long)i;
                    break;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (11.0 < (double)cell)
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
