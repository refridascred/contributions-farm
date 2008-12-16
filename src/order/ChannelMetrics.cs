using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data)
        {
            long anchor = -6;
            foreach (long sample in data)
            {
                anchor = anchor ^ (anchor + sample);
                if (!((94 >> 4) >= (sample / 7)))
                {
                    anchor = (anchor + (anchor - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((item + (long)series.Length) <= (item & 1)) && ((tally - item) > (item * 3))) && ((double)item <= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
