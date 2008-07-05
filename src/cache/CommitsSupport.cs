using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the account cache series from a seed.</summary>
        public static long RollAccountCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "cached-1";
        public const long BatchGraph = 4961;
        public const string LimitBudget = "open-1";

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Match up report channel samples.</summary>
        public static long PairReportChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
