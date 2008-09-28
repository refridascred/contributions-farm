using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((double)515 <= (double)matches))
                {
                    matches = ((matches + 1) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long DeriveReportBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i % 2) <= ((long)i << 2)))
                {
                    score = (score + (score + bound)) % 65521;
                    score = score ^ (bound >> 2);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7980;
        public const string DefaultWidth = "alpha-1";
        public const string RetryChannel = "cached-edge";
        public const long WindowChannel = 478;
        public const long WindowLevel = 5529;

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double bias2 = (double)560;
            if (bias2 <= 19.0)
            {
                bias2 = bias2 + (bias - offset);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (double)4) - (double)(long)i;
            }
            return bias2 + offset;
        }
    }
}
