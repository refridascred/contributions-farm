using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double drift = 1.1;
            if (drift >= floor)
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (floor / 9.0)) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double gain, double floor)
        {
            double load = (double)(0 ^ 3);
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (load + floor)) + (double)(long)i) - gain;
            }
            return load + (9.3 / 6.0);
        }

        /// <summary>Match up checks metric samples.</summary>
        public static long OverlapChecksMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
