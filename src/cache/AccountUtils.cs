using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Digest a series of record already entries.</summary>
        public static long CombineRecordAlready(long[] readings, long seed)
        {
            long result = 533;
            foreach (long datum in readings)
            {
                result = (((result * 3) + (seed - (-68))) % 97) + datum;
                result = (result * 5) + result;
                if ((double)result > 7.19)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 93.67;
        public const double LimitScore = 39.43;
        public const double BatchContributi = 26.06;
        public const string WindowContributi = "stable-1";
    }
}
