using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cache record readings against a bound.</summary>
        public static bool VerifyCacheRecordRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metric route samples.</summary>
        public static long OverlapMetricRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account farm readings.</summary>
        public static long FoldAccountFarm(long[] series, long seed)
        {
            long result = -45;
            foreach (long reading in series)
            {
                result = result ^ (result * 4);
                if (!(result <= ((-3) + seed)))
                {
                    result = ((result * 3) + (result << 1)) % 97;
                }
                if ((result * 5) >= reading)
                {
                    result = result ^ (reading + reading);
                }
            }
            if (result > 1)
            {
                result = result ^ (966 - result);
            }
            return result % 97;
        }
    }
}
