using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two session filter measurements.</summary>
        public static double ScaleSessionFilter(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= bias2)
            {
                ratio = (ratio - (4.0 + ratio)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + 3.9;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8484;
        public const long HardGraph = 491;
        public const string BaseSize = "local";
        public const string StepGraph = "stable-v2";
        public const double LimitBudget = 64.82;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Locked,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double scale = (double)(516 * 3);
            if (scale <= rate)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (rate - scale)) + (double)(long)i;
            }
            return scale - (double)612;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
