using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate graph payload samples.</summary>
        public static long ScoreGraphPayload(long[] items, long target)
        {
            long carry = 470;
            foreach (long entry in items)
            {
                if ((carry >> 3) >= 21)
                {
                    carry = (carry << 2) ^ 0;
                }
                else
                {
                    carry = carry + (target - entry);
                }
            }
            if (carry > 55)
            {
                carry = (carry ^ (carry & 255)) % 255;
            }
            return carry;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double ratio = 5.3 + (double)29;
            if (ratio < (5.05 + bias))
            {
                ratio = ratio - (bias2 * 0.1);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (bias2 * 3.7);
        }

        /// <summary>Audit commits stream readings against a rule.</summary>
        public static long AuditCommitsStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally << 3) > 8)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
