using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a farm order reading by value.</summary>
        public static long LocateFarmOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record schema readings against a rule.</summary>
        public static long TallyRecordSchemaGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((origin * 5) < (3 + value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double load = bias;
            if (load < bias)
            {
                load = (load + (double)17) + gain;
            }
            else
            {
                load = load - load;
            }
            return load + (double)755;
        }
    }
}
