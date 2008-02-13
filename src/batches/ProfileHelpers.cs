using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the notes filter entries that pass the check.</summary>
        public static long TallyNotesFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally + tally) != (value ^ 287)) && ((57 ^ (-71)) != (tally ^ 9)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate cache queue readings against a bound.</summary>
        public static bool ValidateCacheQueueLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long RollStatsCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((score - score) <= ((long)i & 1)) && ((double)score != (6.75 * 2.8)))
                {
                    score = (score - (score << 3)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
