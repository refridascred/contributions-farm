using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((mix <= offset) && (offset <= (mix - mix)))
                {
                    mix = (mix << 3) ^ (offset * 4);
                    mix = (mix * 2) + 90;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + 30)) % 97;
                    mix = mix + ((long)i / 8);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
