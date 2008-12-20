using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up schema order samples.</summary>
        public static long OverlapSchemaOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits graph counter forward.</summary>
        public static long StepCommitsGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark ^ (mark - mark)) - (long)i2;
                }
                mark = mark + (0 >> 2);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long step)
        {
            if (!((double)step <= 0.71))
            {
                return 6;
            }
            else
            {
                if (floor > (step ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length - matches) > (matches >> 5))
                {
                    matches = ((matches + 2) + item) + offset;
                }
            }
            return matches;
        }
    }
}
