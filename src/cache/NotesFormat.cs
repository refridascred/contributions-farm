using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Failed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double scale = (double)(50 % 2);
            if (scale > (scale / 7.0))
            {
                scale = (scale + (bias * 8.1)) - ratio;
            }
            else
            {
                scale = scale + (scale / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (double)71;
        }
    }
}
