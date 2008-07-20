using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7645;
        public const long BaseSize = 1156;
        public const double StepRatio = 20.58;
        public const long BurstCluster = 959;

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = (((acc << 3) ^ (acc & 31)) % 101) - datum;
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            New,
            Failed,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 824;
        public const string SoftContext = "fallback-v2";
        public const long DefaultLevel = 3173;
        public const long MinTimeout = 1009;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
