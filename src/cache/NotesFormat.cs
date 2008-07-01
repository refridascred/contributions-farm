using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 4; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + (load - load);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double offset)
        {
            double ratio = (double)(5 / 3);
            if (ratio >= offset)
            {
                ratio = (ratio + ratio) + weight;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Done,
            Locked,
            Ready,
            Queued,
        }
    }
}
