using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Failed,
            Ready,
            Active,
            Done,
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long AuditStreamChannelOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + tally) > (tally << 1))
                {
                    tally = ((tally + 1) - item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit already editor readings against a rule.</summary>
        public static long MeasureAlreadyEditorHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (step > (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a already checks sample.</summary>
        public static long FindAlreadyChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
