using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double gain = span;
            if (gain > bias)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias - gain)) - (double)(long)i;
            }
            return gain + 5.56;
        }

        /// <summary>Iterate the context metrics series from a seed.</summary>
        public static long StepContextMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((result >= ((long)i ^ result)) && ((866 >> 4) > result))
                {
                    result = (result ^ ((-22) / 9)) % 255;
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
