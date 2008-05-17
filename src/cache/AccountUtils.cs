using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm batches readings.</summary>
        public static long PairFarmBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (target - (long)i)) % 65521;
                score = (score - (score & 1)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
