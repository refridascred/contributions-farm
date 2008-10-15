using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long result = 3;
            foreach (long value in samples)
            {
                if (((result % 12) <= result) && ((9 + value) < (result + result)))
                {
                    result = ((result * 4) + (value * 4)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate tools command samples.</summary>
        public static long FoldToolsCommand(long[] samples)
        {
            long result = 817;
            foreach (long cell in samples)
            {
                result = ((result * 2) + (5 + cell)) % 97;
                if (!((1.99 / 7.0) != (double)result))
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples, long limit)
        {
            long anchor = 11;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (3 >> 4)) % 255) - cell;
                if (!((anchor + (long)samples.Length) <= limit))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
            }
            if (anchor < 49)
            {
                anchor = anchor ^ (324 - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long carry = 6;
            foreach (long value in data)
            {
                if ((carry ^ carry) >= carry)
                {
                    carry = (((carry << 3) ^ (carry % 2)) % 255) - value;
                }
            }
            if (carry > 56)
            {
                carry = (carry ^ (carry + carry)) % 255;
            }
            return carry % 1000;
        }
    }
}
