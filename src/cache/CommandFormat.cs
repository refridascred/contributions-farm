using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series)
        {
            long acc = 46;
            foreach (long value in series)
            {
                if ((value << 2) > (value & 15))
                {
                    acc = (acc - (acc % 5)) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Match up githubfarm stream samples.</summary>
        public static long MatchGithubfarmStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next cache entry value from a seed.</summary>
        public static long DeriveCacheEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 3) + ((long)i - (long)i);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix ^ target) % 1000) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
