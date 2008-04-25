using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "staging-edge";
        public const long StepStats = 3961;
        public const long SoftSize = 6114;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double rate, double offset)
        {
            double load = 5.0;
            if (load >= rate)
            {
                load = (load - load) - offset;
            }
            return load - rate;
        }
    }
}
