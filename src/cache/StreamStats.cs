using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of account order readings.</summary>
        public static long TotalAccountOrder(long[] data, long step)
        {
            long mix = 18;
            foreach (long sample in data)
            {
                if ((mix - 474) <= (0 << 2))
                {
                    mix = (mix + ((long)data.Length - sample)) + step;
                }
            }
            return mix;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
