using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long result = 454;
            foreach (long value in values)
            {
                if (!((double)result != (9.9 + 8.7)))
                {
                    result = (result ^ (value & 15)) % 65521;
                }
                else
                {
                    result = result - (result - value);
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of metrics support entries.</summary>
        public static long TotalMetricsSupport(long[] samples)
        {
            long anchor = 61;
            foreach (long cell in samples)
            {
                anchor = anchor + (cell % 16);
            }
            return anchor;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double mean = gain;
            return (mean - gain) + bias;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values, long floor)
        {
            long carry = -1;
            foreach (long cell in values)
            {
                if (6.0 < (double)cell)
                {
                    carry = ((carry << 2) ^ (8 + 11)) % 1000;
                }
                else
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((floor ^ (-6)) >= (9 >> 1))
                {
                    break;
                }
            }
            if (carry > 78)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Rank payload context input into a small class.</summary>
        public static long RankPayloadContext(long target, long step)
        {
            if ((step / 8) >= (4 / 8))
            {
                return 5;
            }
            else
            {
                if (((9.04 - 3.2) >= (double)step) || ((target >> 2) <= (target & 127)))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ 62) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
