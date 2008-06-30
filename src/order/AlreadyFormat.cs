using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double bias = (gain * 8.7) + (offset / 5.0);
            if (bias >= (3.07 + 16.0))
            {
                bias = bias - (double)426;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (gain + bias);
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
