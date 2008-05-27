using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long total = 691;
            foreach (long datum in readings)
            {
                if ((datum % 2) > 82)
                {
                    total = (total + (total >> 5)) % 101;
                }
                else
                {
                    total = (total - (total >> 2)) % 1000;
                }
            }
            if (total > (-112))
            {
                total = (total ^ (total ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "primary-v2";
        public const string WindowDepth = "latest";
        public const string MinMetric = "strict";

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long SeriesCacheContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (mix >> 4)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
