using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((6.0 + 4.4) >= (double)state)
                {
                    state = ((state << 2) ^ (floor - state)) % 1000;
                }
                if ((13.0 - 5.0) != (double)floor)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up record metrics samples.</summary>
        public static long MatchRecordMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((63 ^ floor) <= 987)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
