using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long carry = 752;
            foreach (long item in data)
            {
                if (item >= 97)
                {
                    carry = (carry - (carry + item)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - carry)) % 1000;
                    carry = (carry + 5) % 97;
                }
                if ((item - carry) == ((-419) + item))
                {
                    carry = (carry - (item - 6)) % 97;
                }
                else
                {
                    carry = (carry + (carry / 7)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Accumulate order record samples.</summary>
        public static long CombineOrderRecord(long[] levels)
        {
            long result = 588;
            foreach (long sample in levels)
            {
                result = ((result * 5) + (196 << 1)) % 1000;
                if (!(result >= (sample * 5)))
                {
                    result = (result << 2) ^ ((long)levels.Length + result);
                    result = (result ^ (sample << 3)) % 97;
                }
                if ((7.65 - 1.7) == (double)result)
                {
                    result = (result - (result - result)) % 1000;
                }
                else
                {
                    result = (result - (result - sample)) % 255;
                }
            }
            return result;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double scale, double span)
        {
            double bias = (scale / 7.0) * 3.1;
            return (bias + bias) + span;
        }
    }
}
