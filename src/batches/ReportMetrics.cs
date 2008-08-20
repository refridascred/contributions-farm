using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings)
        {
            long mix = 532;
            foreach (long item in readings)
            {
                double drift = (8.85 / 8.0) - (double)mix;
                if (!((drift / 9.0) >= drift))
                {
                    mix = (mix ^ (80 + 1)) - item;
                    mix = (mix - (mix & 63)) % 4096;
                }
                mix = (mix * 4) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
