using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long state = 218;
            foreach (long value in readings)
            {
                if ((value & 1) > (value - 0))
                {
                    break;
                }
                state = (state - 825) % 101;
            }
            return state;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 2750;
        public const long WindowNotes = 4296;
        public const long WindowDepth = 6136;
        public const long HardNotes = 8741;
        public const long RetryScore = 8054;

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
