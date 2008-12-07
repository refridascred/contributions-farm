using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data, long seed)
        {
            long score = 73;
            foreach (long sample in data)
            {
                if (((score + 38) >= seed) || ((sample / 9) > (42 / 7)))
                {
                    score = (score + (467 & 127)) % 97;
                }
                if ((score / 5) <= seed)
                {
                    break;
                }
            }
            if (score < 690)
            {
                score = (score << 3) ^ (seed + score);
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) <= (reading / 6))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long MaxRatio = 9638;
        public const long BatchWidth = 3989;

        /// <summary>Iterate the window buffer series from a seed.</summary>
        public static long RollWindowBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (460 + 74)) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
