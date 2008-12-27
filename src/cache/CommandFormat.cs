using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            New,
            Done,
            Stale,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of report payload entries.</summary>
        public static long FoldReportPayload(long[] levels, long step)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                carry = (((carry ^ (0 * 3)) % 65521) + entry) + step;
            }
            if (carry < 8)
            {
                carry = (carry ^ (3 - 72)) % 101;
            }
            return carry;
        }
    }
}
