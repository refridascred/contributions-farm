using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix << 3) ^ (16 / 4)) % 101) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long TallyNotesContextHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen < (seen + seen))
                {
                    seen = ((seen + 3) ^ cell) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
