using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next payload graph value.</summary>
        public static double AdjustPayloadGraph(double ratio, double floor)
        {
            double weight = (ratio * 1.0) / 2.0;
            if (weight > (weight - ratio))
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight * 6.87)) - (double)(long)i;
            }
            return weight + 6.0;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double mean = scale * 2.7;
            if (mean <= (mean - mean))
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + (double)255;
            }
            return mean - floor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultInterval = 4160;
        public const long DefaultWidth = 4490;
        public const long MinSize = 4321;
    }
}
