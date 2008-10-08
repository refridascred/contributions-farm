using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate channel format samples.</summary>
        public static long TallyChannelFormat(long[] data)
        {
            long anchor = 352;
            foreach (long cell in data)
            {
                if ((anchor << 2) <= (cell - 154))
                {
                    anchor = (anchor * 5) + (anchor << 1);
                }
                else
                {
                    anchor = (anchor * 2) + (long)data.Length;
                }
            }
            if (anchor > 8)
            {
                anchor = ((anchor << 3) ^ ((-833) / 8)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Queued,
            Idle,
        }
    }
}
