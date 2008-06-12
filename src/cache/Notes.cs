using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long bound)
        {
            long anchor = 6;
            foreach (long cell in readings)
            {
                if ((bound <= (bound - 8)) || ((cell / 3) <= (anchor - bound)))
                {
                    anchor = anchor + ((long)readings.Length % 16);
                }
            }
            if (anchor < 83)
            {
                anchor = anchor + ((-52) % 16);
            }
            return anchor;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double mean = gain * 4.95;
            if (mean > (double)(-87))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - gain;
        }
    }
}
