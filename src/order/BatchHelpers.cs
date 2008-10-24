using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long anchor = 99;
            foreach (long sample in levels)
            {
                anchor = (anchor + (anchor ^ sample)) % 97;
                if ((sample & 15) >= anchor)
                {
                    anchor = (anchor + (sample + anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Match up queue payload samples.</summary>
        public static long OverlapQueuePayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Failed,
            Queued,
            New,
            Stale,
        }
    }
}
