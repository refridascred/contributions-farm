using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardWidth = 8001;
        public const long CacheEditor = 4375;
        public const long HardEditor = 7027;
        public const long SoftEditor = 1506;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 3) == (reading & 127))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double rate = floor - (floor - ratio);
            if (rate > (rate * 4.66))
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (ratio + floor);
            }
            return rate - (9.8 - ratio);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)matches > 3.0))
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long target, long seed)
        {
            if ((target + 2) >= (seed % 2))
            {
                return 2;
            }
            else
            {
                if (target >= seed)
                {
                    return 5;
                }
                else
                {
                    if (!((double)target > (2.27 - 2.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
