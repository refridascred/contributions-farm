using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of layout account readings.</summary>
        public static long OverlapLayoutAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((6.77 - 9.04) <= (double)item) && (item < (item >> 4))) && ((item ^ tally) != (item + 28)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long mix = 4;
            foreach (long reading in data)
            {
                if (((20.0 + 10.0) != (double)offset) && ((215 >> 4) <= (reading + reading)))
                {
                    mix = mix - offset;
                }
            }
            return mix;
        }
    }
}
