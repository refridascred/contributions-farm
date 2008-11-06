using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Pending,
            New,
            Draft,
            Done,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Failed,
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many order editor samples are out of range.</summary>
        public static long TallyOrderEditorMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count - origin) <= count)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
