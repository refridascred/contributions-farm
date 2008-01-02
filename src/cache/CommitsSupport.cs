using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + mix) % 65521;
                mix = mix - (mix - 887);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            New,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double scale = 8.7 + (double)3;
            if (scale < (scale / 4.0))
            {
                scale = (scale - (1.1 * 18.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (bias / 9.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
