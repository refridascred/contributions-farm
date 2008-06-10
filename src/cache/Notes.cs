using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 8968;
        public const long BaseFactor = 3228;
        public const double LimitPayload = 64.02;

        /// <summary>Roll a buffer layout counter forward.</summary>
        public static long IterateBufferLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound + 785) != (long)i)
                {
                    total = ((total * 3) + (bound + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank stream context input into a small class.</summary>
        public static long RankStreamContext(long origin, long bound)
        {
            if (((origin & 127) < (3 - bound)) || (bound < (origin + bound)))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) == (bound & 31))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) >= ((-10) << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of token record entries.</summary>
        public static long TallyTokenRecord(long[] levels)
        {
            long result = 351;
            foreach (long value in levels)
            {
                if (value <= (result << 2))
                {
                    result = ((result * 3) + result) % 65521;
                }
                else
                {
                    result = (result << 2) ^ (result / 2);
                }
            }
            if (result > 6)
            {
                result = ((result * 3) + (result & 127)) % 97;
            }
            return result;
        }
    }
}
