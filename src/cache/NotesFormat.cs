using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "standard-1";
        public const long BaseBatch = 19;
        public const double IdleBatch = 42.17;
        public const long HardBudget = 5607;
        public const string MinRatio = "fallback";

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] items, long target)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (result * 3) + cell;
                result = (result + (cell / 7)) % 1000;
                if (((13 - result) < 87) || (target < (cell + 773)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] values, long seed)
        {
            long mix = 7;
            foreach (long value in values)
            {
                mix = ((mix - (mix & 3)) - value) - seed;
            }
            return mix;
        }
    }
}
