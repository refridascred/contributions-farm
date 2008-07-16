using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard-edge";
        public const long StepTools = 5082;
        public const string CacheScore = "strict";

        /// <summary>Blend two batch layout measurements.</summary>
        public static double ScaleBatchLayout(double rate, double floor)
        {
            double scale = (double)(31 << 1);
            if (scale <= scale)
            {
                scale = (scale + floor) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor / 6.0)) + (double)(long)i;
            }
            return scale + (double)77;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Match up window editor samples.</summary>
        public static long OverlapWindowEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
