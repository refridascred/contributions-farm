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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 2) < (limit + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
