using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cache githubfarm samples are out of range.</summary>
        public static long MeasureCacheGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > ((long)data.Length % 100))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((4.23 / 3.0) < (double)tally) && (tally <= (tally + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSpan = 7346;
        public const long StepBuffer = 9436;
        public const long BatchBuffer = 8441;
        public const double MaxRatio = 67.26;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count > bound)
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] samples)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ (mix >> 5)) ^ value;
                if ((4 + mix) >= (mix ^ 3))
                {
                    mix = ((mix << 3) ^ (mix % 24)) % 65521;
                }
                else
                {
                    mix = (mix * 4) + (23 + mix);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5765;
        public const long IdleToken = 6880;
        public const double MaxCount = 93.1;
    }
}
