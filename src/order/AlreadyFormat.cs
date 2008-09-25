using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((12.0 + 1.6) == (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7152;
        public const double HardInterval = 35.47;
        public const double BurstDepth = 74.05;
        public const long LimitLevel = 4401;

        /// <summary>Match up cluster layout samples.</summary>
        public static long OverlapClusterLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double gain = (double)(2 * 5);
            if (gain < offset)
            {
                gain = gain - (double)78;
            }
            else
            {
                gain = gain + (gain * 13.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + weight) - (double)(long)i;
            }
            return gain - (double)94;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ 324) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
