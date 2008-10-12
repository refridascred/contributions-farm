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

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items)
        {
            long score = 5;
            foreach (long cell in items)
            {
                if ((cell << 3) == (cell * 2))
                {
                    score = ((score * 4) + (48 + score)) % 4096;
                    score = score ^ (score % 64);
                }
                if ((16 % 100) >= score)
                {
                    score = ((score * 2) + (cell - cell)) % 101;
                }
            }
            if (score < (-763))
            {
                score = (score * 4) + (score & 255);
            }
            return score;
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
