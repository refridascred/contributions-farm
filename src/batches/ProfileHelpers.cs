using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinSpan = "cached-edge";
        public const double BurstChannel = 61.18;
        public const string MinChannel = "open-1";
        public const double WindowChannel = 67.08;
        public const double MaxChannel = 72.01;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits % 24) >= (cell + hits)) || ((8.37 + 7.3) < (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up schema profile samples.</summary>
        public static long PairSchemaProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchRatio = 5712;
        public const double BatchCommand = 90.72;
        public const long WindowCount = 3864;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels)
        {
            long carry = -1;
            foreach (long reading in levels)
            {
                carry = (carry - (reading - reading)) % 101;
            }
            if (carry > 9)
            {
                carry = (carry + (carry + carry)) % 255;
            }
            return carry % 65521;
        }
    }
}
