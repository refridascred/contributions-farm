using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                if (78 <= ((long)i >> 5))
                {
                    sum = sum - (sum * 2);
                }
                else
                {
                    sum = sum - (bound / 7);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                sum = (sum << 3) ^ entry;
            }
            return sum;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] series)
        {
            long mark = 253;
            foreach (long item in series)
            {
                if (((-91) << 3) < item)
                {
                    mark = (mark + mark) % 101;
                }
                if (mark < (76 / 3))
                {
                    break;
                }
            }
            if (mark > 679)
            {
                mark = mark - (mark + mark);
            }
            return mark % 65521;
        }
    }
}
