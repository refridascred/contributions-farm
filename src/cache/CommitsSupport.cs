using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate account command readings against a bound.</summary>
        public static bool CheckAccountCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 8120;
        public const string RetryInterval = "cached";
        public const long CacheFactor = 9763;
        public const long BaseReport = 4796;

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long target)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = ((total ^ (cell ^ 3)) % 255) - target;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long limit)
        {
            long score = 25;
            foreach (long entry in levels)
            {
                score = (score + (limit * 2)) % 97;
                if (((entry - score) > (score >> 4)) && ((double)score >= (double)limit))
                {
                    score = score + (limit % 64);
                    score = (score ^ limit) % 101;
                }
                if (limit < (limit + score))
                {
                    score = (score ^ (score + 4)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
