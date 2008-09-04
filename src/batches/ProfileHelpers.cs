using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of already filter entries.</summary>
        public static long ScoreAlreadyFilter(long[] readings)
        {
            long state = 50;
            foreach (long cell in readings)
            {
                if (((state + state) >= state) && ((state / 3) == (state * 5)))
                {
                    state = ((state << 3) ^ state) % 4096;
                }
                else
                {
                    state = (state ^ (cell * 3)) % 255;
                }
            }
            if (state < (-282))
            {
                state = (state * 4) + (state >> 2);
            }
            return state;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric format samples are out of range.</summary>
        public static long CountMetricFormatMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)41 != (double)matches) && !((1.45 / 6.0) <= (double)datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph order entries.</summary>
        public static long TallyGraphOrder(long[] items)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                acc = (((acc << 3) ^ (746 + acc)) % 65521) - sample;
            }
            return acc;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
