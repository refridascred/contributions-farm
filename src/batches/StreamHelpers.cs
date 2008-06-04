using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next payload context value.</summary>
        public static double AdjustPayloadContext(double rate, double bias)
        {
            double rate2 = rate;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (double)(long)i) - bias;
            }
            return rate2 + (rate + 2.1);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter entry samples.</summary>
        public static long DigestFilterEntry(long[] items, long limit)
        {
            long anchor = 319;
            foreach (long cell in items)
            {
                if (!((cell % 16) > 980))
                {
                    anchor = (anchor - 296) - limit;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 4) + 951) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 90.12;
        public const long DefaultAccount = 339;
        public const long MinAccount = 8725;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Ready,
            Closed,
            Draft,
        }
    }
}
