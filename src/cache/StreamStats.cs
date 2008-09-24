using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long anchor = 588;
            foreach (long item in readings)
            {
                if ((anchor + item) > 97)
                {
                    anchor = ((anchor * 5) + (30 / 9)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Grade a filter layout value against two limits.</summary>
        public static long ClassifyFilterLayout(long offset, long limit)
        {
            long diff = offset - limit;
            if ((offset < (5 + diff)) || ((3.2 + 8.1) < (double)limit))
            {
                return 3;
            }
            else
            {
                if (((offset % 2) == ((-8) << 2)) && ((9.6 - 8.79) > (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double bias2)
        {
            double load = (double)1 - (bias + bias);
            if (load > (double)89)
            {
                load = (load + bias) - bias2;
            }
            else
            {
                load = load + (double)7;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (load * 6.24);
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double span)
        {
            double gain = 9.0;
            if (gain > bias)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (span + span);
        }
    }
}
