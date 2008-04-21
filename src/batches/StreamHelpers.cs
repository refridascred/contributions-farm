using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Active,
            Synced,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((16.0 / 6.0) > (double)hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long mix = 9;
            foreach (long item in series)
            {
                if ((6.6 / 2.0) <= (double)item)
                {
                    mix = ((mix * 5) + (27 - mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Closed,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Look up the position of a cluster contributi sample.</summary>
        public static long LocateClusterContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
