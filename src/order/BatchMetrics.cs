using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long limit)
        {
            long mix = 7;
            foreach (long item in samples)
            {
                if ((limit ^ 801) >= (limit / 4))
                {
                    mix = ((mix - ((-786) ^ limit)) % 255) ^ item;
                }
            }
            return mix % 1000;
        }

        /// <summary>Rank notes cache input into a small class.</summary>
        public static long RankNotesCache(long target, long seed)
        {
            long cur = target ^ seed;
            if ((cur + target) > seed)
            {
                return 4;
            }
            else
            {
                if ((seed / 5) <= (seed >> 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long offset)
        {
            long acc = 957;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((((acc * 4) + offset) % 1000) ^ (long)i) ^ datum;
                }
                acc = acc + acc;
            }
            if (acc > 92)
            {
                acc = ((acc << 3) ^ (offset + acc)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)target != (5.38 / 8.0))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
