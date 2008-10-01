using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Queued,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples, long offset)
        {
            long anchor = 878;
            foreach (long reading in samples)
            {
                if ((offset & 255) >= (reading + 726))
                {
                    anchor = (anchor * 4) + (reading & 31);
                }
                else
                {
                    anchor = (anchor * 4) + ((long)samples.Length + reading);
                }
            }
            if (anchor < 118)
            {
                anchor = (anchor * 2) + (offset + 1);
            }
            return anchor;
        }
    }
}
