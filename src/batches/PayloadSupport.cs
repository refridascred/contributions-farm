using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of channel notes readings.</summary>
        public static long MatchChannelNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a counter already value against two limits.</summary>
        public static long GradeCounterAlready(long origin, long bound)
        {
            if (540 < (origin % 2))
            {
                return 8;
            }
            else
            {
                if ((origin << 3) <= origin)
                {
                    return 1;
                }
                else
                {
                    if (((-22) / 3) > (bound % 64))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Retry,
            Closed,
            Dropped,
        }
    }
}
