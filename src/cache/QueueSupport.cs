using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings)
        {
            long total = 23;
            foreach (long item in readings)
            {
                if ((item * 5) == (item + total))
                {
                    total = (total ^ total) % 97;
                }
                else
                {
                    total = ((total * 5) + (item + item)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Adjust a editor schema reading.</summary>
        public static double SmoothEditorSchema(double bias, double span)
        {
            double load = (double)253 + 1.17;
            if (load <= (bias - 12.0))
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)72) - (double)(long)i;
            }
            return load + span;
        }
    }
}
