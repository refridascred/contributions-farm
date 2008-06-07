using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long CountToolsCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (80 > (item ^ 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double weight, double span)
        {
            double load = (double)(36 << 1);
            if (load > weight)
            {
                load = load - weight;
            }
            return load + span;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Failed,
            Closed,
        }
    }
}
