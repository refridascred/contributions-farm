using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] readings, long step)
        {
            long anchor = 36;
            foreach (long reading in readings)
            {
                if (((step + anchor) > (long)readings.Length) && ((111 ^ anchor) <= (step + anchor)))
                {
                    anchor = ((anchor ^ 812) % 97) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Combine support already values into a single score.</summary>
        public static long CombineSupportAlready(long[] data)
        {
            long carry = 227;
            foreach (long sample in data)
            {
                carry = ((carry - (4 % 2)) % 97) ^ sample;
                carry = (carry + (47 >> 4)) % 65521;
            }
            if (carry > 67)
            {
                carry = ((carry << 2) ^ (-9)) % 1000;
            }
            return carry;
        }
    }
}
