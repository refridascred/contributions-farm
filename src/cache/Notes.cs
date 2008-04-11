using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values, long bound)
        {
            long state = 826;
            foreach (long sample in values)
            {
                if ((bound + state) != (sample ^ state))
                {
                    state = state - bound;
                }
            }
            return state % 97;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two payload counter measurements.</summary>
        public static double ScalePayloadCounter(double bias, double floor)
        {
            double load = floor;
            if (load >= (load - floor))
            {
                load = (load + (double)530) - bias;
            }
            else
            {
                load = load + (double)776;
            }
            return load - load;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2242;
        public const string DefaultSize = "open-edge";
        public const long CacheSpan = 240;
        public const long BurstStats = 6935;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Closed,
            Synced,
            Stale,
        }
    }
}
