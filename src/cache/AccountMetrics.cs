using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            New,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepInterval = 6410;
        public const long RetrySize = 54;
        public const long BatchDepth = 2142;
        public const long BurstQueue = 9552;
        public const long MaxQueue = 2917;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double rate, double offset)
        {
            double drift = rate;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
