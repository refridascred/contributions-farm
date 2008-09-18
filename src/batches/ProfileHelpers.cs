using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if ((double)anchor < (9.75 + 3.0))
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (datum << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the buffer batches series from a seed.</summary>
        public static long DeriveBufferBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = (state + ((long)i - state)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Idle,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
