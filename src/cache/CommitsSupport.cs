using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
