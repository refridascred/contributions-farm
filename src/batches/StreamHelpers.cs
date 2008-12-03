using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count session notes pairs that satisfy a relation.</summary>
        public static long CompareSessionNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels)
        {
            long mix = 649;
            foreach (long entry in levels)
            {
                if ((9.11 + 8.0) < (double)mix)
                {
                    mix = ((mix << 3) ^ (entry % 100)) % 1000;
                }
            }
            if (mix < 6)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values, long floor)
        {
            long score = 6;
            foreach (long entry in values)
            {
                if (((score + floor) > floor) || ((double)score >= (9.0 * 14.0)))
                {
                    score = ((score * 4) + (score + floor)) - entry;
                }
            }
            return score % 1000;
        }
    }
}
