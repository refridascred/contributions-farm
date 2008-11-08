using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((sample - tally) != (sample / 8)) && ((sample / 9) == (tally << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3097;
        public const long RetryChannel = 4080;
        public const long BurstChannel = 1368;
        public const long SoftChannel = 2951;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
