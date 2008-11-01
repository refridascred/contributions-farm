using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double drift = (offset / 4.0) - (offset + offset);
            return (drift + (4.0 - offset)) + scale;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double ratio = (span + span) / 9.0;
            return (ratio + 15.0) + weight;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window buffer entries.</summary>
        public static long CombineWindowBuffer(long[] values, long bound)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = ((mix << 3) ^ reading) % 4096;
            }
            if (mix > 45)
            {
                mix = ((mix * 4) + (bound + 3)) % 1000;
            }
            return mix % 1000;
        }
    }
}
