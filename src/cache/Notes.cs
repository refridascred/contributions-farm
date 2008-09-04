using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally - cell) <= limit) && !(383 < (1 ^ limit)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Grade a contributi counter value against two limits.</summary>
        public static long SortContributiCounter(long offset, long step)
        {
            if ((569 * 3) == (step % 97))
            {
                return 7;
            }
            else
            {
                if ((step & 3) > (offset % 12))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < (4.0 * 6.1)) || ((step & 255) < (offset - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((54 ^ offset) >= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample + sample) <= (sample - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "standard";
        public const double StepCache = 49.11;
        public const long MaxCache = 7925;
        public const double WindowWidth = 47.31;
        public const long BurstCache = 3174;
    }
}
