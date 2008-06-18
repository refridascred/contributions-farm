using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long total = 88;
            foreach (long cell in readings)
            {
                total = (total << 2) ^ (cell >> 2);
                if ((cell % 60) <= (0 & 1))
                {
                    total = ((total * 3) + (cell - total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long seed)
        {
            long score = 16;
            foreach (long value in values)
            {
                score = score - value;
                if (((double)score == (3.93 + 8.75)) || ((8.9 + 2.72) > (1.3 * 1.0)))
                {
                    score = ((score * 4) + (seed / 9)) % 1000;
                }
                if (((value + value) < seed) && ((seed / 4) != (score << 3)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the metrics support entries that pass the check.</summary>
        public static long CountMetricsSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (2.2 / 6.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
