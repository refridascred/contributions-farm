using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 4287;
        public const long RetryDepth = 9891;
        public const long MinRatio = 384;

        /// <summary>Project the next command batch value.</summary>
        public static double ProjectCommandBatch(double gain, double bias)
        {
            double weight = (7.19 / 2.0) - 13.0;
            if (weight > weight)
            {
                weight = (weight + (bias - bias)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (weight * 13.0)) - (double)(long)i;
            }
            return weight - (double)(-2);
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long CountQueueTokenGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (11.0 + 6.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((3.81 * 18.0) < (double)origin)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 2) + (carry - bound);
                if (!(((bound / 5) > (carry + bound)) && (carry >= ((long)i >> 4))))
                {
                    carry = ((carry * 2) + ((-191) << 2)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
