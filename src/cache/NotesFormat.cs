using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a tools support sample.</summary>
        public static long LocateToolsSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Idle,
            Failed,
            Synced,
            Active,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double floor)
        {
            double drift = 2.3;
            if (drift <= (8.0 / 4.0))
            {
                drift = (drift - (double)8) - floor;
            }
            else
            {
                drift = drift + 2.5;
            }
            return drift + gain;
        }
    }
}
