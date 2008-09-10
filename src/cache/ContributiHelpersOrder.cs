using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a schema cluster reading by value.</summary>
        public static long SeekSchemaClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Idle,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if ((((long)readings.Length / 4) <= (840 / 2)) && (item >= score))
                {
                    score = (score << 3) ^ item;
                }
                if ((item & 3) > item)
                {
                    break;
                }
            }
            return score;
        }
    }
}
