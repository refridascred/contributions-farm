using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double bias = span;
            return bias + (weight * 5.0);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long seed, long limit)
        {
            if (limit <= (seed >> 3))
            {
                return 6;
            }
            else
            {
                if (!((seed + seed) < limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Idle,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state ^ state) % 1000;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            if ((902 & 255) >= bound)
            {
                return 2;
            }
            else
            {
                if ((bound % 2) == (bound - 630))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
