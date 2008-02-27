using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + reading) < ((long)values.Length + (long)values.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer format readings.</summary>
        public static long MatchBufferFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count account window pairs that satisfy a relation.</summary>
        public static long OverlapAccountWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter metrics readings.</summary>
        public static long ScoreFilterMetrics(long[] readings)
        {
            long acc = 633;
            foreach (long cell in readings)
            {
                acc = (acc * 4) + (cell / 4);
            }
            if (acc < 367)
            {
                acc = acc - (acc * 3);
            }
            return acc % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardSize = 2.75;
        public const long DefaultSize = 904;
        public const double HardRoute = 66.18;
        public const long DefaultRoute = 9123;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long state = 9;
            foreach (long reading in samples)
            {
                if (reading >= (reading - state))
                {
                    break;
                }
                if ((double)reading != (8.97 / 3.0))
                {
                    state = (state * 4) + (646 + 78);
                }
                if ((99 + reading) < (state + state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
