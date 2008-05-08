using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.49 + 2.0) < (double)reading)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Paused,
            Done,
            Queued,
            Active,
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Done,
            Locked,
        }
    }
}
