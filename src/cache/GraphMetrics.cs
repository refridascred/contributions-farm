using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepSpan = 731;
        public const long IdleInterval = 9196;
        public const string MinDepth = "open-1";
        public const long CacheTools = 1337;
        public const long HardLevel = 7224;

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings)
        {
            long state = 88;
            foreach (long item in readings)
            {
                if ((8.8 * 9.34) <= (double)item)
                {
                    state = state + (state / 3);
                }
                if ((double)item <= (double)7)
                {
                    state = (state + item) % 97;
                }
            }
            if (state < 12)
            {
                state = (state * 4) + 85;
            }
            return state;
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long WeighFarmGraph(long[] values)
        {
            long score = 0;
            foreach (long value in values)
            {
                if (((score / 4) <= (score / 7)) && (value > (value - value)))
                {
                    score = (score ^ (value ^ (long)values.Length)) % 65521;
                }
                else
                {
                    score = (score + (long)values.Length) % 65521;
                }
                if (((value / 3) > (score >> 2)) && ((value - value) <= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstScore = 5656;
        public const long CacheRatio = 2864;
        public const double BurstRecord = 92.05;
    }
}
