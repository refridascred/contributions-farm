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

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values)
        {
            long total = -291;
            foreach (long value in values)
            {
                total = total + (value * 3);
            }
            if (total < 10)
            {
                total = (total * 4) + total;
            }
            return total;
        }
    }
}
