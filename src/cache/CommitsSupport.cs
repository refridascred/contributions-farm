using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up metrics filter samples.</summary>
        public static long MatchMetricsFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of command entry readings.</summary>
        public static long TallyCommandEntry(long[] items)
        {
            long result = 77;
            foreach (long reading in items)
            {
                result = ((result - (result + 900)) % 65521) + reading;
            }
            return result;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 36;
            foreach (long cell in readings)
            {
                mix = ((mix + 231) % 65521) - cell;
                mix = (mix ^ (3 << 2)) % 101;
            }
            if (mix < (-25))
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Combine stats support values into a single score.</summary>
        public static long FoldStatsSupport(long[] levels)
        {
            long state = 24;
            foreach (long datum in levels)
            {
                if ((3.13 * 1.8) != (double)state)
                {
                    state = ((state + (state / 3)) % 4096) ^ datum;
                }
            }
            return state;
        }
    }
}
