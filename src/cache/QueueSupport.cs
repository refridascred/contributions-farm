using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "local-v2";
        public const double HardInterval = 73.71;
        public const long BaseCount = 7496;
        public const long IdleCommits = 4486;

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples, long floor)
        {
            long acc = -1;
            foreach (long sample in samples)
            {
                if (((sample % 24) > (floor >> 3)) || (acc >= (long)samples.Length))
                {
                    acc = (acc ^ 548) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell > ((-710) + 37)) && (bound >= (cell + 6))) || ((cell >> 2) <= (4 + 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
