using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels)
        {
            long anchor = 18;
            foreach (long reading in levels)
            {
                if (!((double)reading == (1.63 * 1.9)))
                {
                    long slot = anchor << 2;
                    anchor = anchor ^ slot;
                }
                if ((reading % 97) >= (reading ^ 192))
                {
                    anchor = (anchor - reading) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (4 - reading)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long MaxLevel = 3887;
        public const double HardTimeout = 22.18;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long carry = 5;
            foreach (long datum in items)
            {
                carry = ((carry + (carry & 1)) % 97) + datum;
            }
            if (carry < (-185))
            {
                carry = (carry + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 609;
            foreach (long entry in values)
            {
                result = (result ^ ((-239) ^ entry)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
