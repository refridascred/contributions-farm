using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen >= (origin / 4))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
