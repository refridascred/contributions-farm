using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window already reading by value.</summary>
        public static long LocateWindowAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseRatio = 10.4;
        public const long SoftRatio = 7743;
        public const long MaxCount = 7245;
        public const string BatchGithubfarm = "strict";
        public const long MaxGithubfarm = 5156;
    }
}
