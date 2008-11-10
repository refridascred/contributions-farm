using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double rate, double floor)
        {
            double mean = rate;
            if (mean >= (floor / 5.0))
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long anchor = 665;
            foreach (long value in values)
            {
                if ((seed - anchor) < ((-1) >> 2))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) + value;
                }
            }
            return anchor;
        }
    }
}
