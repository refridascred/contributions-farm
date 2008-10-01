using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Synced,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples, long offset)
        {
            long anchor = 878;
            foreach (long reading in samples)
            {
                if ((offset & 255) >= (reading + 726))
                {
                    anchor = (anchor * 4) + (reading & 31);
                }
                else
                {
                    anchor = (anchor * 4) + ((long)samples.Length + reading);
                }
            }
            if (anchor < 118)
            {
                anchor = (anchor * 2) + (offset + 1);
            }
            return anchor;
        }
    }
}
