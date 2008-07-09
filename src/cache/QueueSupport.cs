using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (entry >> 1))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
