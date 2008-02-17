using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (offset > reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (2.9 + 7.15))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long bound, long limit)
        {
            long step = bound - limit;
            if ((bound * 5) > (bound + limit))
            {
                return 3;
            }
            else
            {
                if ((step >> 4) < (bound / 3))
                {
                    return 7;
                }
                else
                {
                    if ((3.55 - 9.7) < (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 + step) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double bias, double bias2)
        {
            double scale = bias2;
            if (scale >= bias2)
            {
                scale = scale - 0.32;
            }
            return scale - bias;
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long TallyTokenFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!((sample + sample) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
