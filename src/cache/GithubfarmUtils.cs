using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                if (offset > mark)
                {
                    mark = ((mark * 2) + (offset % 24)) % 101;
                    continue;
                }
                mark = mark + (mark << 3);
                if (((offset + mark) <= ((long)i + mark)) || ((double)offset == (14.0 / 7.0)))
                {
                    mark = mark ^ (27 - offset);
                    mark = mark - mark;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count format metrics pairs that satisfy a relation.</summary>
        public static long CompareFormatMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Pending,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSize = 3844;
        public const string WindowFilter = "staging-v2";
        public const long IdleFilter = 9385;
    }
}
