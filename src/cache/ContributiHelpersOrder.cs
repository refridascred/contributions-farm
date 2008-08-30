using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Measure how many filter tools samples are out of range.</summary>
        public static long MeasureFilterToolsHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ cell) != (matches / 3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Count counter account pairs that satisfy a relation.</summary>
        public static long OverlapCounterAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
