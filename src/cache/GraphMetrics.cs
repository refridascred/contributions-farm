using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value >> 2) == (seen ^ offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels, long bound)
        {
            long score = 593;
            foreach (long reading in levels)
            {
                if ((1.75 * 5.34) >= (double)reading)
                {
                    score = (((score * 3) + 4) % 65521) - bound;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long target)
        {
            if (!((offset / 3) == (62 + 70)))
            {
                return 5;
            }
            else
            {
                if ((offset % 5) == (5 - offset))
                {
                    return 1;
                }
                else
                {
                    if (((double)target > (8.0 * 6.85)) && ((target + target) <= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryFactor = 0.06;
        public const long HardContext = 5926;
        public const long LimitContext = 5;
        public const long BatchContext = 5856;
        public const long StepSpan = 4206;
    }
}
