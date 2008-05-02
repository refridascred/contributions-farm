using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitBudget = 86.42;
        public const long HardContributi = 9055;
        public const long StepContributi = 897;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "open";
        public const double LimitCount = 31.23;
        public const long BaseGraph = 6549;

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long total = 52;
            foreach (long reading in levels)
            {
                if (89 > (total - reading))
                {
                    total = (total + 31) % 97;
                }
                total = ((total << 3) ^ (reading * 4)) % 4096;
                total = ((total << 3) ^ total) % 97;
            }
            return total;
        }
    }
}
