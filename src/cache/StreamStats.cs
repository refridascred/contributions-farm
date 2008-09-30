using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the account format series from a seed.</summary>
        public static long StepAccountFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((carry - carry) > ((long)i >> 1))
                {
                    continue;
                }
                long seen = 96;
                if ((seen << 2) <= seen)
                {
                    seen = ((seen * 4) + (seen & 31)) % 255;
                    seen = seen - (733 - carry);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of window command readings.</summary>
        public static long MatchWindowCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc << 3) ^ ((long)i2 - acc);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
