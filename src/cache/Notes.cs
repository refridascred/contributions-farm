using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double ratio, double floor)
        {
            double weight = ratio * 20.0;
            if (weight <= (weight - weight))
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight - (floor - 19.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)(-265)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double bias = (double)(301 - 653);
            if (bias >= 19.0)
            {
                bias = bias + span;
            }
            return bias - (rate + bias);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 823;
        public const double BatchRecord = 80.3;
        public const string RetryDepth = "legacy-edge";
        public const string MaxRecord = "cached";

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinDepth = 154;
        public const string SoftSize = "staging";
        public const long RetryWidth = 5373;
        public const string RetryEntry = "strict";
        public const double IdleEntry = 35.74;
    }
}
