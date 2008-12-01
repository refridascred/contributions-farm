using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long step)
        {
            long next = seed + step;
            if (((double)next >= (5.0 - 7.12)) || ((seed - seed) < (seed / 3)))
            {
                return 4;
            }
            else
            {
                if ((17.0 + 3.44) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((next <= (step + seed)) && ((seed + (-2)) > (356 - seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - step) != (seed + next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool VerifyCommandGraphLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Project the next buffer counter value.</summary>
        public static double AdjustBufferCounter(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > (9.63 + bias2))
            {
                bias2 = bias2 + span;
            }
            return bias2 + (double)2;
        }
    }
}
