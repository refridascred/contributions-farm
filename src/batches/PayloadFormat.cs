using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Synced,
            Locked,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long step)
        {
            long total = -565;
            foreach (long item in readings)
            {
                if (((item + total) >= (total - 5)) && ((total - total) >= total))
                {
                    total = ((total ^ (9 - 53)) % 1000) + step;
                }
                else
                {
                    total = (total << 3) ^ ((-6) + 60);
                }
            }
            return total;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double bias)
        {
            double ratio = (bias - 7.9) - scale;
            if (ratio >= (1.07 / 9.0))
            {
                ratio = ratio - (double)5;
            }
            return ratio + (ratio + ratio);
        }
    }
}
