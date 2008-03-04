using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 5) >= (datum << 2)) && (((double)(long)samples.Length != (2.0 * 19.0)) || ((count - count) >= (405 / 8))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series, long bound)
        {
            long carry = 3;
            foreach (long sample in series)
            {
                carry = ((carry + (bound & 31)) % 65521) ^ sample;
            }
            return carry % 4096;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long target, long target2)
        {
            long span = target ^ target2;
            if (!((double)target != (0.4 - 4.6)))
            {
                return 6;
            }
            else
            {
                if ((span + (-1)) == (target2 ^ span))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
