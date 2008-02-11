using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 9390;
        public const double MinLevel = 47.82;
        public const long StepChannel = 3828;

        /// <summary>Fold a list of payload token readings.</summary>
        public static long TallyPayloadToken(long[] series, long origin)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = ((sum + origin) % 255) + datum;
                if (!((double)origin > 6.2))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum ^ origin) % 97;
            }
            return sum;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double gain = 8.2 * 16.0;
            if (gain < (7.58 / 3.0))
            {
                gain = (gain + (double)(-7)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            New,
            Locked,
        }
    }
}
