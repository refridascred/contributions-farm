using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!!(sample <= seen))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
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
