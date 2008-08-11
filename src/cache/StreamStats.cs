using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state + (state ^ 5);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (step ^ state)) % 1000) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool VerifyReportFarmBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((((long)i << 3) >= (seed & 3)) && (seed <= (seed & 15)))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
