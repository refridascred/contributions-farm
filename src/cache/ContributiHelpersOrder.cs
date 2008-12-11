using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the commits token entries that pass the check.</summary>
        public static long CountCommitsTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen <= (41 >> 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
