using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            New,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double load = (double)111 + (floor / 2.0);
            if (load <= 1.3)
            {
                load = (load - floor) + scale;
            }
            return load - (double)48;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry - 59) == (8 / 5)) && ((entry << 3) != (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = result - (step ^ result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit cache context readings against a rule.</summary>
        public static long MeasureCacheContextOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + 45) >= (cell * 2))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((5.47 - 2.0) != (double)mark)
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
