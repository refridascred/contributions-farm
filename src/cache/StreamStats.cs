using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first notes command entry that matches the target.</summary>
        public static long SeekNotesCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Failed,
            Closed,
            Done,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - 9) <= (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
