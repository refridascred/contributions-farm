using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine batch support values into a single score.</summary>
        public static long TallyBatchSupport(long[] items, long target)
        {
            long score = 6;
            foreach (long sample in items)
            {
                score = ((score + (target - score)) % 4096) ^ sample;
                if ((double)score == (2.18 + 7.8))
                {
                    score = (score ^ 7) % 4096;
                }
            }
            if (score < 791)
            {
                score = score ^ 379;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + (631 - offset);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 5784;
        public const double LimitCommand = 53.85;
        public const long IdleCommand = 2783;
    }
}
