using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (46 < (offset >> 5))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double drift = rate;
            if (drift < (floor / 5.0))
            {
                drift = drift - (drift - rate);
            }
            else
            {
                drift = drift + (rate + drift);
            }
            return drift + 20.0;
        }
    }
}
