using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Active,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 8972;
        public const long DefaultSize = 9092;
        public const long WindowGraph = 3491;
        public const double RetryInterval = 45.01;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
