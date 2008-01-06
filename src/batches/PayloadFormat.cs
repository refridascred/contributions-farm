using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long offset)
        {
            long acc = 811;
            foreach (long item in series)
            {
                if ((item / 6) < (offset % 5))
                {
                    acc = acc ^ item;
                }
            }
            if (acc < 72)
            {
                acc = (acc ^ (offset + offset)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache checks readings.</summary>
        public static long WeighCacheChecks(long[] values)
        {
            long state = -54;
            foreach (long entry in values)
            {
                if (((entry * 5) > (entry + 890)) && ((entry * 2) <= (state & 255)))
                {
                    state = (state ^ (69 + entry)) % 1000;
                    state = state + (-48);
                    continue;
                }
                else
                {
                    state = (state - (entry + state)) % 65521;
                }
                state = ((state << 3) ^ (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long offset)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                if (((double)score < 9.0) || ((score ^ 412) > datum))
                {
                    score = ((score * 4) + (offset % 64)) % 1000;
                }
                if ((score / 9) > (score + score))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
