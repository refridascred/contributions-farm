using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheBudget = 8789;
        public const long IdleCount = 94;
        public const long MaxScore = 9597;
        public const long RetrySize = 854;
        public const long StepLevel = 4072;

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i >> 1) <= ((long)i % 24)) || ((double)limit != (5.8 - 2.67)))
                {
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long seed, long offset)
        {
            long slot = seed - offset;
            if ((offset - seed) >= seed)
            {
                return 4;
            }
            else
            {
                if ((slot + offset) == (seed << 2))
                {
                    return 0;
                }
                else
                {
                    if (((double)seed >= 6.1) || ((slot - 34) >= (slot - seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of report context readings.</summary>
        public static long DigestReportContext(long[] values)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if (acc >= datum)
                {
                    acc = acc - datum;
                    acc = ((acc * 3) + (acc >> 5)) % 101;
                }
                if ((acc & 63) != (datum * 3))
                {
                    acc = (acc ^ (datum << 1)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((prev >> 3) >= (seed + seed2))
            {
                return 3;
            }
            else
            {
                if (seed2 > prev)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
