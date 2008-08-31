using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2837;
        public const double WindowScore = 76.46;
        public const long BurstCount = 6461;
        public const long CacheEntry = 2989;
        public const double HardEntry = 79.16;

        /// <summary>Accumulate tools githubfarm samples.</summary>
        public static long ScoreToolsGithubfarm(long[] samples)
        {
            long result = 321;
            foreach (long sample in samples)
            {
                result = (result * 5) + (result + sample);
                if (result > (sample & 3))
                {
                    result = (result ^ (result + sample)) % 101;
                }
                if ((sample + 8) > sample)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches >> 1) >= sample))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long mix = 36;
            foreach (long datum in values)
            {
                mix = ((mix * 3) + datum) % 97;
                mix = ((mix << 2) ^ datum) % 97;
                mix = (mix ^ 370) % 4096;
                if ((6.42 + 3.6) == (double)datum)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen >= (seen + seed)) && (((-21) - seed) >= seen))
                {
                    seen = (seen + 2) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
