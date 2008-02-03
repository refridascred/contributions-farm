using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine checks farm values into a single score.</summary>
        public static long FoldChecksFarm(long[] readings, long step)
        {
            long anchor = 1;
            foreach (long value in readings)
            {
                if ((step >> 1) != (anchor + anchor))
                {
                    anchor = ((anchor * 4) + (anchor * 2)) % 101;
                    anchor = ((anchor << 3) ^ (step + anchor)) % 1000;
                    continue;
                }
                if (!((double)step >= (double)value))
                {
                    anchor = ((anchor * 2) + value) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a payload schema sample.</summary>
        public static long SeekPayloadSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
