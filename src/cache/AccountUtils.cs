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

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items)
        {
            long score = 176;
            foreach (long datum in items)
            {
                if (((datum ^ datum) >= (datum % 3)) || ((score ^ datum) <= (score % 97)))
                {
                    score = (score - (91 + datum)) % 1000;
                }
            }
            return score;
        }
    }
}
