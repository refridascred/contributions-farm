using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long carry = -976;
            foreach (long entry in readings)
            {
                if ((764 * 5) >= entry)
                {
                    carry = (carry ^ (entry & 255)) % 255;
                }
            }
            if (carry < 10)
            {
                carry = carry + carry;
            }
            return carry % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultSpan = "local-v2";
        public const double SoftCount = 21.34;
        public const long LimitSize = 9697;
        public const double SoftWidth = 78.24;
        public const long BaseDepth = 3349;
    }
}
