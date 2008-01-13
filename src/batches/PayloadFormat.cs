using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = (score - (long)i) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitRatio = "cached-1";
        public const long BurstSize = 716;
        public const long DefaultTools = 8315;
        public const long BatchTools = 7528;
        public const long WindowCount = 201;

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double rate = (double)7 / 9.0;
            if (rate <= (weight / 7.0))
            {
                rate = (rate - (weight / 8.0)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (weight / 8.0)) + (double)(long)i;
            }
            return rate - (rate / 6.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSpan = 4283;
        public const long MaxRoute = 1263;
        public const long SoftRoute = 7010;
        public const double MaxDepth = 82.95;
        public const double SoftRatio = 33.97;
    }
}
