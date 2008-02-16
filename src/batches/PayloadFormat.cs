using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long mark = 25;
            foreach (long datum in samples)
            {
                if ((mark + (-456)) <= (mark + mark))
                {
                    mark = ((mark << 3) ^ datum) % 1000;
                }
                else
                {
                    mark = (mark + (mark + 0)) % 255;
                }
                if (datum <= (datum % 7))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long limit)
        {
            long delta = target ^ limit;
            if ((target ^ delta) <= (delta - 5))
            {
                return 7;
            }
            else
            {
                if ((double)target != (3.82 * 15.0))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
