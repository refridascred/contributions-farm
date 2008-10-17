using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long offset)
        {
            long total = 951;
            foreach (long sample in values)
            {
                long gap = (sample % 12) / 8;
                if (((3 >> 4) > gap) || (total <= (680 + gap)))
                {
                    long cur = sample - (76 - 5);
                    total = total - (cur - offset);
                }
                if (!(119 > total))
                {
                    total = (total - (6 + sample)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + sample) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a route stats reading by value.</summary>
        public static long LookupRouteStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
