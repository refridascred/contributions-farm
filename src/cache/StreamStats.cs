using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many notes editor samples are out of range.</summary>
        public static long CountNotesEditorGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches < (item + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Dropped,
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Match up channel cluster samples.</summary>
        public static long PairChannelClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
