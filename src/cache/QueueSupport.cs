using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long step)
        {
            long edge = target ^ step;
            if (((edge << 1) == (edge + edge)) || ((edge * 3) == (step & 31)))
            {
                return 2;
            }
            else
            {
                if ((double)edge < (3.3 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if (((900 ^ 6) < (edge + target)) && (step < (step - target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step > (7 >> 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((12.0 - 6.0) == (double)hits)
                {
                    hits = ((hits + 2) + value) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
