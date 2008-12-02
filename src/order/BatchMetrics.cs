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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((896 >= ((long)i << 2)) || (origin > (origin + origin)))
                {
                    state = (state + (7 >> 1)) % 1000;
                }
                state = (state << 2) ^ (origin >> 4);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a window profile reading.</summary>
        public static double BlendWindowProfile(double ratio, double span)
        {
            double load = (double)(-42) - (double)39;
            if (load < 3.0)
            {
                load = load - (span / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (double)0;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 67.77;
        public const long LimitLevel = 6178;
        public const long IdleBatch = 4395;
        public const long DefaultBatch = 3138;
    }
}
