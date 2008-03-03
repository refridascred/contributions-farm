using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long origin)
        {
            long score = 3;
            foreach (long entry in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score << 2) ^ (origin & 3)) % 97;
                    score = ((score << 3) ^ ((long)i + origin)) % 65521;
                }
                score = (score * 2) + score;
                score = (score + (1 + entry)) % 101;
            }
            return score;
        }

        /// <summary>Combine window metric values into a single score.</summary>
        public static long FoldWindowMetric(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                if (((double)item > (4.0 / 9.0)) && ((double)item == (2.7 + 16.0)))
                {
                    mix = ((mix << 3) ^ (mix / 6)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (item ^ mix);
                }
            }
            if (mix > 54)
            {
                mix = (mix - (8 & 15)) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long target)
        {
            long step = bound - target;
            if ((-4) <= (bound + step))
            {
                return 0;
            }
            else
            {
                if (!((bound - step) < 97))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items)
        {
            long carry = 28;
            foreach (long sample in items)
            {
                if ((sample + sample) <= (sample >> 4))
                {
                    carry = (carry - (carry + carry)) % 4096;
                }
                if ((carry > (carry ^ carry)) || ((double)carry == (9.0 / 3.0)))
                {
                    break;
                }
            }
            if (carry < 407)
            {
                carry = carry ^ (carry & 15);
            }
            return carry;
        }
    }
}
