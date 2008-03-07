using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a editor checks figure with a bias.</summary>
        public static double BlendEditorChecks(double bias, double floor)
        {
            double gain = (double)4 * 8.37;
            if (gain > (double)1)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain - bias;
            }
            return gain - (0.12 + 2.79);
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] series)
        {
            long result = 16;
            foreach (long cell in series)
            {
                if ((37 - 1) == (cell << 3))
                {
                    result = (result ^ (3 ^ cell)) % 97;
                }
            }
            if (result < 69)
            {
                result = (result - (result << 2)) % 255;
            }
            return result;
        }

        /// <summary>Derive the next route farm value from a seed.</summary>
        public static long SeriesRouteFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (state * 3)) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Draft,
            Done,
            Locked,
            Queued,
        }
    }
}
