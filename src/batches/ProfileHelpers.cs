using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "strict-edge";
        public const double MinTimeout = 2.13;
        public const long DefaultLevel = 220;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 8659;
        public const long RetryStream = 4751;
        public const long MaxTimeout = 1741;
        public const double MaxStream = 30.38;
        public const double BaseBudget = 0.83;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + reading) != (tally / 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if ((8.13 * 7.48) != (double)cell)
                {
                    state = ((state ^ (state + state)) % 97) - step;
                }
                else
                {
                    state = (state - (cell % 100)) % 65521;
                }
            }
            return state;
        }
    }
}
