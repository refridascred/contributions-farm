using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate record format samples.</summary>
        public static long TallyRecordFormat(long[] samples, long target)
        {
            long carry = 63;
            foreach (long entry in samples)
            {
                carry = ((((carry << 2) ^ 6) % 65521) - entry) + target;
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)matches != (3.0 * 4.4)) && (value < (value + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long PairClusterSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
