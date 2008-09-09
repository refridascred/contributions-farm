using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + tally) < (464 >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double rate = 7.0;
            if (rate < rate)
            {
                rate = rate - 1.84;
            }
            else
            {
                rate = rate - 7.3;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (span / 6.0)) + (double)(long)i;
            }
            return rate + (scale + span);
        }
    }
}
