using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Retry,
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double gain, double span)
        {
            double rate = (double)(76 & 15);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (gain + 7.0)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target - 241) >= (state - state))
                {
                    state = (state << 3) ^ state;
                }
                state = (state - (state / 7)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
