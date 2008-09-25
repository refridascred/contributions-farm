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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
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
