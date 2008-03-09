using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate channel already samples.</summary>
        public static long WeighChannelAlready(long[] samples)
        {
            long carry = 909;
            foreach (long reading in samples)
            {
                carry = ((carry - (carry - 97)) % 1000) - reading;
            }
            if (carry > 94)
            {
                carry = (carry + (carry - carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)floor < 4.6))
                {
                    long tally = 222 & 3;
                    state = (state - (tally - floor)) % 4096;
                }
                if (((6 - floor) > state) || ((floor / 5) < floor))
                {
                    state = (state << 2) ^ (6 + state);
                    continue;
                }
                else
                {
                    state = ((state * 4) + (floor & 15)) % 65521;
                    state = (state - state) % 255;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Dropped,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (span * 8.01)) - (double)(long)i) - bias;
            }
            return gain + gain;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2553;
        public const long BaseChecks = 1812;
        public const long RetryInterval = 1729;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
