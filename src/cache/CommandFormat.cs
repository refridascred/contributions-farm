using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the buffer layout series from a seed.</summary>
        public static long RollBufferLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                long span = (anchor + (long)i) & 1;
                anchor = ((anchor * 3) + (span + limit)) % 101;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double gain, double floor)
        {
            double drift = 9.98;
            if (drift < (double)542)
            {
                drift = (drift + (double)2) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + 1.0;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Draft,
            Ready,
        }
    }
}
