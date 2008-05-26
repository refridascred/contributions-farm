using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session graph measurements.</summary>
        public static double BlendSessionGraph(double ratio, double floor)
        {
            double scale = 4.7;
            if (scale > (1.2 + ratio))
            {
                scale = (scale + ratio) - floor;
            }
            else
            {
                scale = scale - 18.0;
            }
            return scale + scale;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 90.39;
        public const long BurstQueue = 4678;
        public const long HardQueue = 4387;
        public const double SoftQueue = 33.78;
    }
}
