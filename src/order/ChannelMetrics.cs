using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine record route values into a single score.</summary>
        public static long DigestRecordRoute(long[] levels, long bound)
        {
            long state = 0;
            foreach (long sample in levels)
            {
                state = (((state * 2) + (21 + sample)) % 97) + bound;
                if ((state - 2) <= (-441))
                {
                    state = state + (46 ^ state);
                }
            }
            return state;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 6) <= (cell >> 1))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
