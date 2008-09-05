using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] values, long floor)
        {
            long sum = 11;
            foreach (long datum in values)
            {
                if ((sum * 3) <= datum)
                {
                    sum = sum ^ (floor - 5);
                }
                else
                {
                    sum = sum + (floor % 10);
                }
            }
            return sum;
        }

        /// <summary>Roll a report cache counter forward.</summary>
        public static long RollReportCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + (result & 63)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Active,
            Done,
            Paused,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((9 + sample) >= sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two order session measurements.</summary>
        public static double ScaleOrderSession(double gain, double bias)
        {
            double weight = bias;
            if (weight < (bias / 9.0))
            {
                weight = (weight - (double)7) - gain;
            }
            return weight + (double)411;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
