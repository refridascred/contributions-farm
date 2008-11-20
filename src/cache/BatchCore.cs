using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long seed, long floor)
        {
            if ((floor & 31) <= floor)
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (9 < (seed - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up token farm samples.</summary>
        public static long PairTokenFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels)
        {
            long mix = -600;
            foreach (long sample in levels)
            {
                mix = (mix ^ (189 & 63)) % 97;
                if (((double)sample > (5.6 / 4.0)) && ((76 / 6) < (mix & 1)))
                {
                    mix = mix + (mix + 16);
                }
            }
            return mix;
        }

        /// <summary>Validate filter account readings against a bound.</summary>
        public static bool ValidateFilterAccountRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
