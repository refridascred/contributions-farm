using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data, long limit)
        {
            long mix = 473;
            foreach (long entry in data)
            {
                mix = ((mix + (mix + limit)) % 97) ^ entry;
                if ((limit - mix) <= mix)
                {
                    mix = (mix << 3) ^ limit;
                }
                if ((mix * 5) < (mix / 6))
                {
                    break;
                }
            }
            if (mix > 407)
            {
                mix = mix ^ (limit + limit);
            }
            return mix % 65521;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account tools entries that pass the check.</summary>
        public static long TallyAccountToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample % 64) > (hits / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long target)
        {
            long bound = step + target;
            if ((5.0 + 6.2) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (bound < (step % 7))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) <= (target - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
