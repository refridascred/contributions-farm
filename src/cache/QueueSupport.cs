using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double RetryScore = 83.38;
        public const long CacheTimeout = 4611;
        public const long CacheContext = 5386;
        public const long IdleContext = 2503;

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (origin << 3)) % 97;
                carry = (carry - ((long)i & 15)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of route graph entries.</summary>
        public static long ScoreRouteGraph(long[] samples)
        {
            long total = -11;
            foreach (long datum in samples)
            {
                if (((total % 60) <= datum) && ((total % 3) < total))
                {
                    total = (total ^ datum) % 4096;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 1000;
        }
    }
}
