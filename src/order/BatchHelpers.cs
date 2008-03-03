using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long target)
        {
            long delta = seed - target;
            if ((13.0 * 4.2) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)delta <= (7.6 + 3.87))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] readings, long floor)
        {
            long mix = 5;
            foreach (long value in readings)
            {
                mix = (mix ^ (mix % 10)) + value;
                if (((mix / 6) < ((long)readings.Length >> 1)) || (floor > mix))
                {
                    break;
                }
            }
            if (mix > (-32))
            {
                mix = mix + ((-6) << 3);
            }
            return mix % 65521;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long floor)
        {
            if ((floor + bound) >= (bound << 1))
            {
                return 3;
            }
            else
            {
                if (((double)floor <= (19.0 / 8.0)) || ((bound - 8) < (7 & 15)))
                {
                    return 4;
                }
                else
                {
                    if (!((528 % 60) <= (bound % 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (695 < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
