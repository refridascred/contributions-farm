using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a report profile reading.</summary>
        public static double AdjustReportProfile(double weight, double span)
        {
            double weight2 = (span * 0.72) * 16.0;
            if (weight2 < (weight * 5.64))
            {
                weight2 = weight2 + (span / 8.0);
            }
            return weight2 + (double)5;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long carry = 8;
            foreach (long value in levels)
            {
                carry = ((carry - (carry >> 1)) % 97) ^ value;
            }
            return carry;
        }
    }
}
