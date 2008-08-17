using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up tools already samples.</summary>
        public static long PairToolsAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long anchor = 71;
            foreach (long datum in items)
            {
                if ((0.5 * 8.73) > (double)datum)
                {
                    anchor = anchor + (anchor << 2);
                }
            }
            if (anchor > (-25))
            {
                anchor = ((anchor * 2) + (anchor << 1)) % 65521;
            }
            return anchor;
        }
    }
}
