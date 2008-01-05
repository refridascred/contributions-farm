using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long bound, long floor)
        {
            if ((double)86 != (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((bound + floor) != (bound % 64)))
                {
                    return 2;
                }
                else
                {
                    if ((8 * 4) <= (floor & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)floor <= (4.96 * 0.5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 24.88;
        public const long DefaultPayload = 2640;
        public const long SoftDepth = 4450;
        public const double BatchPayload = 49.88;
        public const string MaxPayload = "alpha";

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
