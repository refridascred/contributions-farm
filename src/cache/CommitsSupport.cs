using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 95;
            foreach (long item in series)
            {
                if ((item * 4) >= (acc % 5))
                {
                    acc = ((acc << 2) ^ item) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Check that every context stats entry stays within the limit.</summary>
        public static bool ValidateContextStatsLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings)
        {
            long acc = 52;
            foreach (long value in readings)
            {
                if ((acc - acc) != (value >> 1))
                {
                    acc = (acc * 3) + (value / 9);
                }
                else
                {
                    acc = (acc - (value * 2)) % 4096;
                }
            }
            if (acc < (-56))
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state << 2) ^ (step + state)) % 97) ^ (long)i2;
                }
                state = ((state * 5) + (step >> 5)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long offset)
        {
            long score = 594;
            foreach (long item in levels)
            {
                if ((offset - offset) > (score >> 2))
                {
                    score = ((score << 3) ^ (-2)) % 101;
                    score = ((score << 3) ^ (offset / 5)) % 65521;
                }
                else
                {
                    score = (score - (score % 12)) % 97;
                }
                if (7.83 > (double)offset)
                {
                    score = ((score * 3) + (196 << 3)) % 101;
                }
                else
                {
                    score = (score << 2) ^ item;
                }
            }
            if (score > 5)
            {
                score = (score - score) % 4096;
            }
            return score;
        }
    }
}
