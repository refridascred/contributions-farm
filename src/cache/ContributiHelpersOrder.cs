using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            New,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long step)
        {
            long state = -5;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)state)
                {
                    state = (state << 3) ^ (step + step);
                    state = state ^ (datum + datum);
                }
                if ((datum + 143) <= step)
                {
                    state = (state + (datum & 127)) % 255;
                }
            }
            return state;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = (gain - (gain - floor)) + scale;
            }
            return gain - (double)7;
        }
    }
}
