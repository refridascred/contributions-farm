using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stats farm entries.</summary>
        public static long DigestStatsFarm(long[] readings, long seed)
        {
            long mix = 7;
            foreach (long entry in readings)
            {
                if (((94 - seed) >= entry) && (mix >= 139))
                {
                    mix = (mix - (mix - entry)) % 4096;
                }
                if (seed > (entry & 63))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double floor)
        {
            double scale = floor - (double)3;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (ratio / 8.0)) + (double)(long)i;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Paused,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Active,
            Draft,
            Pending,
            Closed,
        }
    }
}
