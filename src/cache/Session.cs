using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Active,
            Pending,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((double)limit >= 4.0))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
