using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long AuditSupportWindowMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell <= matches)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            New,
            Active,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long anchor = 876;
            foreach (long value in levels)
            {
                if ((7.0 + 4.65) > (double)value)
                {
                    anchor = anchor + (97 - value);
                    break;
                }
                if (((8.62 / 9.0) <= (double)value) && ((double)5 >= (5.0 - 6.64)))
                {
                    anchor = anchor + (value << 3);
                }
                else
                {
                    anchor = anchor - ((-99) % 24);
                }
            }
            if (anchor > 92)
            {
                anchor = anchor - anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double gain, double bias)
        {
            double weight = gain;
            if (weight <= (gain - bias))
            {
                weight = weight - (weight / 9.0);
            }
            else
            {
                weight = weight + (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)(-433);
        }
    }
}
