using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double gain = ratio;
            if (gain > (gain * 2.4))
            {
                gain = gain + (floor / 4.0);
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor - gain)) - (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Active,
            Done,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Closed,
            New,
        }
    }
}
