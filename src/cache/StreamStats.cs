using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((tally - tally) < (3 - entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (seed + seed)) % 101;
                if (((-19) >= (seed + mix)) || ((seed << 1) == (seed - mix)))
                {
                    mix = ((mix * 4) + (mix & 3)) % 97;
                }
                else
                {
                    mix = mix + (6 << 3);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
