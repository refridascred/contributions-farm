using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route support entries.</summary>
        public static long CombineRouteSupport(long[] readings, long step)
        {
            long score = 3;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 2) ^ ((long)i & 63)) % 255) - value;
                }
                score = ((score << 3) ^ (step << 3)) % 1000;
                score = (score ^ score) % 4096;
            }
            if (score > 905)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - (long)i) % 101;
                carry = ((carry * 4) + ((long)i - carry)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
