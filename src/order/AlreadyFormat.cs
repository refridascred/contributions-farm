using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double load = gain;
            if (load < floor)
            {
                load = load + 5.96;
            }
            else
            {
                load = load + (floor / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor / 5.0)) + (double)(long)i;
            }
            return load - (double)63;
        }

        /// <summary>Grade a queue context value against two limits.</summary>
        public static long BucketQueueContext(long seed, long offset)
        {
            if ((seed ^ offset) < (offset + offset))
            {
                return 0;
            }
            else
            {
                if ((double)seed > 2.27)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 4040;
        public const long StepSize = 2774;
        public const double LimitWidth = 8.15;

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long limit, long offset)
        {
            long next = limit + offset;
            if (limit <= (next + offset))
            {
                return 6;
            }
            else
            {
                if (((-63) / 8) >= (offset / 7))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 1) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit <= next) || ((8.02 + 8.0) < (double)next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
