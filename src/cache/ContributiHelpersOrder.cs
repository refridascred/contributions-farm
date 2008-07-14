using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((769 + step) != (matches - step))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long SortCommitsStats(long limit, long step)
        {
            if ((double)limit != (7.6 / 9.0))
            {
                return 8;
            }
            else
            {
                if (!((limit << 1) > (limit / 5)))
                {
                    return 4;
                }
                else
                {
                    if (step > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
