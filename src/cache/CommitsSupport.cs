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

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((10.0 - 3.93) <= (double)datum) || (((long)data.Length + tally) >= (datum & 1))) && ((0.1 - 1.0) != (double)datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
