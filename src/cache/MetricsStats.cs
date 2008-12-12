using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster route samples.</summary>
        public static long TallyClusterRoute(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if (!((entry / 4) > entry))
                {
                    state = state + state;
                }
                if ((state - entry) > (entry & 3))
                {
                    break;
                }
            }
            if (state < (-36))
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ ((-8) ^ offset)) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
