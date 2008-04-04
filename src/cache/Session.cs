using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySpan = 3042;
        public const long IdleNotes = 3032;
        public const long WindowLevel = 6942;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((945 - acc) != (step - acc))
                {
                    acc = (acc ^ (acc - step)) % 97;
                    acc = (acc + (-31)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (ratio - rate);
        }
    }
}
