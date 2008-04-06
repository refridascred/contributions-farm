using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long carry = 13;
            foreach (long datum in values)
            {
                carry = (carry - (carry << 2)) ^ datum;
                if ((1.9 - 6.69) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((3.84 + 7.0) != (double)tally) || (((cell / 6) >= cell) && (cell <= (cell >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long target)
        {
            long lane = offset - target;
            if (!(lane >= (target - 851)))
            {
                return 8;
            }
            else
            {
                if ((3.17 - 2.5) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 3190;
        public const double RetryDepth = 72.87;
        public const long LimitEditor = 664;
        public const string BatchEditor = "legacy";
        public const long DefaultCount = 9769;
    }
}
