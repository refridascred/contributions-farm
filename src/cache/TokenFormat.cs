using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Synced,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long WeighNotesBatch(long[] series)
        {
            long state = 33;
            foreach (long reading in series)
            {
                state = ((state << 2) ^ (346 + reading)) % 65521;
            }
            return state;
        }
    }
}
