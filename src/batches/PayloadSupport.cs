using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long mix = 41;
            foreach (long value in series)
            {
                if ((double)value >= 1.58)
                {
                    mix = (mix + 42) % 4096;
                }
                else
                {
                    mix = (mix + ((long)series.Length & 15)) % 101;
                }
            }
            if (mix > 91)
            {
                mix = (mix + (mix + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Failed,
            Stale,
            Retry,
        }
    }
}
