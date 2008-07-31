using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 96.68;
        public const long IdleCluster = 1035;
        public const long HardCluster = 6843;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (15 >= (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long limit)
        {
            long carry = 422;
            foreach (long cell in levels)
            {
                if ((double)carry == (9.3 + 13.0))
                {
                    carry = (carry << 2) ^ (cell >> 3);
                }
            }
            if (carry > (-16))
            {
                carry = (carry - (limit - carry)) % 65521;
            }
            return carry % 4096;
        }
    }
}
