using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits >= (hits & 31))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long bound)
        {
            if (96 <= (floor / 7))
            {
                return 8;
            }
            else
            {
                if (((bound - bound) <= (bound & 1)) && ((floor << 3) > bound))
                {
                    return 4;
                }
                else
                {
                    if (51 < (floor / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double BlendGraphFilter(double bias, double span)
        {
            double scale = bias * 5.02;
            if (scale > span)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (span * 5.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "latest-1";
        public const double WindowCommits = 4.43;
        public const double BurstFactor = 68.41;
        public const string IdleLevel = "alpha-v2";

        /// <summary>Derive the next channel report value from a seed.</summary>
        public static long IterateChannelReport(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state - (step % 10);
                state = ((state << 3) ^ state) % 65521;
                if (step < (state + step))
                {
                    state = (state << 3) ^ (step >> 3);
                }
                else
                {
                    state = ((state << 3) ^ (state - state)) % 1000;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
