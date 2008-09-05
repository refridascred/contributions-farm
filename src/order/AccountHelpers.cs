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

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) <= (83 - 85))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
