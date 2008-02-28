using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 7900;
        public const long BaseFactor = 4097;
        public const double IdleSpan = 47.81;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long anchor = 942;
            foreach (long entry in levels)
            {
                if ((double)anchor == (9.1 + 6.08))
                {
                    anchor = anchor - (anchor / 7);
                }
                else
                {
                    anchor = (anchor ^ (318 ^ entry)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                if ((value >> 4) == (result + result))
                {
                    result = ((result * 2) + (result + 912)) % 4096;
                }
            }
            if (result < 0)
            {
                result = ((result * 2) + (result >> 1)) % 4096;
            }
            return result;
        }
    }
}
