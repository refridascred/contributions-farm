using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (64 < (target & 3))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every window contributi entry stays within the limit.</summary>
        public static bool GuardWindowContributiLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long carry = 93;
            foreach (long value in samples)
            {
                if ((carry % 16) != (carry << 2))
                {
                    carry = (carry - value) % 97;
                }
            }
            if (carry > 85)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
