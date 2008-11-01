using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank context token input into a small class.</summary>
        public static long GradeContextToken(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if ((floor2 - bound) < (-40))
            {
                return 8;
            }
            else
            {
                if ((floor + 8) > (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
