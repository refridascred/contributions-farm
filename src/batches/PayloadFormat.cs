using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Stale,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long step2)
        {
            if ((double)step != (6.0 / 5.0))
            {
                return 2;
            }
            else
            {
                if ((7.8 - 14.0) != (double)step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((-8) >> 3) != (value - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
