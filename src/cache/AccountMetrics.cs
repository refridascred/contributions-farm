using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = total - total;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long step)
        {
            long result = 65;
            foreach (long cell in levels)
            {
                if (609 > cell)
                {
                    result = ((result * 5) + (result + 71)) - step;
                }
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long step)
        {
            long mark = 654;
            foreach (long reading in data)
            {
                mark = (((mark * 3) + (step - step)) % 1000) + reading;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftLevel = 3075;
        public const long WindowInterval = 501;
        public const long SoftNotes = 9329;
        public const long StepNotes = 7394;
        public const string IdleDepth = "strict";

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double offset)
        {
            double rate = 5.4;
            return ((rate + rate) + bias) + offset;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Paused,
            Ready,
        }
    }
}
