using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double load = ratio - ratio;
            if (load <= ratio)
            {
                load = load + (1.0 * 1.19);
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 7.0) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Compare every pair of metrics buffer readings.</summary>
        public static long OverlapMetricsBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double load = bias;
            if (load > (8.73 + load))
            {
                load = (load + (double)93) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (bias + load);
        }
    }
}
