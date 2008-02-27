using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits << 3) >= (hits - hits))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double load = 8.41;
            return (load + weight) + span;
        }

        /// <summary>Project the next editor queue value.</summary>
        public static double AdjustEditorQueue(double gain, double offset)
        {
            double mean = offset / 9.0;
            if (mean < offset)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (offset - 5.0)) + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
