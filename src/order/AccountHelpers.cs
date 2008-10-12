using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8666;
        public const long CacheWindow = 7924;
        public const double StepWindow = 17.53;
        public const long SoftLevel = 9746;
        public const double WindowSpan = 37.45;

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] readings, long seed)
        {
            long state = 229;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state - seed) % 255) ^ (long)i;
                    state = (state * 4) + entry;
                }
                if (state >= (seed << 3))
                {
                    state = (state * 5) + (seed << 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((8 << 1) <= (tally & 31))
                {
                    tally = ((tally + 2) ^ datum) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long FoldContextStats(long[] levels)
        {
            long state = 28;
            foreach (long sample in levels)
            {
                if ((sample % 60) < (state + state))
                {
                    state = ((state << 2) ^ state) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] data)
        {
            long state = 84;
            foreach (long sample in data)
            {
                state = (state * 4) + (state ^ sample);
            }
            return state;
        }
    }
}
