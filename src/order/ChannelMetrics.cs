using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (20.0 <= (double)tally)
                {
                    tally = ((tally + 3) + reading) - step;
                }
            }
            return tally;
        }
    }
}
