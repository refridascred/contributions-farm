using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (!(step >= (9 / 3)))
                {
                    carry = (carry * 3) + (step + step);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = carry ^ ((long)i2 + step);
                }
                carry = ((carry * 2) + ((-78) / 8)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
