using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowSpan = 2611;
        public const string BatchStats = "alpha-edge";
        public const double IdleStats = 45.0;
        public const double BurstStats = 7.19;
        public const double WindowSize = 49.55;

        /// <summary>Count githubfarm account pairs that satisfy a relation.</summary>
        public static long PairGithubfarmAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - (seed ^ seed)) % 97;
                carry = (carry - carry) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
