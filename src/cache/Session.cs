using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long total = 810;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total - (total * 5)) ^ (long)i;
                }
                if (((datum & 1) <= (datum - (long)samples.Length)) && ((double)total >= (3.95 / 4.0)))
                {
                    total = (total - (datum + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long bound)
        {
            long mix = 463;
            foreach (long reading in data)
            {
                if (((mix & 63) != (reading + 54)) || ((double)reading < (19.0 - 3.5)))
                {
                    mix = (mix + (reading - mix)) % 97;
                }
                else
                {
                    mix = (mix + (bound >> 1)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4492;
        public const long MaxScore = 1059;
        public const long SoftBuffer = 396;
        public const double StepFactor = 78.67;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((origin & 1) > origin) && (origin <= (cell + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
