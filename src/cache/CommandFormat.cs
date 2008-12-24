using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 12.59;
        public const long StepScore = 8968;
        public const double BaseAlready = 7.9;
        public const double RetryDepth = 94.29;
        public const string LimitAlready = "staging-v2";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double scale, double offset)
        {
            double gain = offset;
            if (gain <= scale)
            {
                gain = gain + (1.98 + scale);
            }
            return gain + (gain - scale);
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i * 3) > seed)
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
