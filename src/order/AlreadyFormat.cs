using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > scale)
            {
                scale2 = scale2 + 5.01;
            }
            return scale2 - (double)2;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long seed)
        {
            if ((limit - seed) <= (seed & 255))
            {
                return 5;
            }
            else
            {
                if (!(seed <= limit))
                {
                    return 8;
                }
                else
                {
                    if (!((limit + 3) < (seed % 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) <= (count / 2))
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
