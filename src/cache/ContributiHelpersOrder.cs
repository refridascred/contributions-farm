using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data)
        {
            long anchor = 300;
            foreach (long value in data)
            {
                if ((double)anchor <= (16.0 + 2.0))
                {
                    anchor = (anchor ^ 31) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ (value + value);
                }
                if ((5 & 15) != (anchor << 3))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
