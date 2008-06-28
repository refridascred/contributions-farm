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

        /// <summary>Project the next buffer queue value.</summary>
        public static double ProjectBufferQueue(double weight, double span)
        {
            double mean = (double)(92 - 9);
            if (mean >= (double)49)
            {
                mean = mean - (span / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight - span)) + (double)(long)i;
            }
            return mean + (double)482;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 2364;
        public const string MaxTimeout = "staging-v2";
        public const string RetryEntry = "staging";

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
