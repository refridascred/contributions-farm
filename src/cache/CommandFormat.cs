using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of cache tools readings.</summary>
        public static long CombineCacheTools(long[] values)
        {
            long total = 99;
            foreach (long value in values)
            {
                total = total + (total >> 3);
                total = ((total << 3) ^ (value + 26)) % 1000;
            }
            if (total < 653)
            {
                total = (total + (total / 4)) % 65521;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6443;
        public const long BaseScore = 4616;
        public const long BatchTimeout = 8618;
        public const long LimitLevel = 1164;
        public const double WindowAlready = 58.92;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((5.5 - 9.0) >= (1.5 - 6.42))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "alpha-v2";
        public const long StepLevel = 5566;
        public const string HardStats = "fallback-v2";
        public const string MinStats = "alpha-v2";
    }
}
