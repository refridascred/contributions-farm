using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long state = -47;
            foreach (long sample in data)
            {
                state = ((state + 0) % 65521) - sample;
            }
            if (state > 80)
            {
                state = (state << 3) ^ (state / 7);
            }
            return state;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long bound)
        {
            if (((double)origin >= (3.92 + 9.69)) || ((bound + bound) >= origin))
            {
                return 3;
            }
            else
            {
                if (((double)origin <= (6.0 - 4.52)) && ((bound * 3) < origin))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 4) != (bound % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many stats batches samples are out of range.</summary>
        public static long AuditStatsBatchesMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((double)seen < (7.86 + 7.35)))
                {
                    seen = ((seen + 2) + reading) + step;
                }
            }
            return seen;
        }
    }
}
