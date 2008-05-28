using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first format githubfarm entry that matches the target.</summary>
        public static long LookupFormatGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series)
        {
            long score = 59;
            foreach (long datum in series)
            {
                if (((double)datum <= (double)score) || ((datum - 33) >= datum))
                {
                    score = ((score << 3) ^ score) % 1000;
                }
                else
                {
                    score = score - (datum - score);
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((488 / 8) < (datum ^ datum)) || ((datum >> 5) < (datum * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxTimeout = 59.31;
        public const long StepRatio = 3875;
        public const long BatchBatches = 1084;
    }
}
