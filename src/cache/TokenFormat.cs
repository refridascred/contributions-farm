using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mix = 645;
            foreach (long sample in readings)
            {
                mix = ((mix * 2) + sample) % 4096;
                if ((((-32) + sample) != (sample ^ 81)) && (5.5 <= (double)sample))
                {
                    mix = (mix - 1) % 101;
                }
            }
            if (mix < (-19))
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                long cur = carry;
                if ((cur << 3) > bound)
                {
                    carry = (carry * 3) + carry;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
