using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long TallyBatchesEditorGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) <= (reading & 15)) && ((reading - matches) == (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch contributi pair into a bucket.</summary>
        public static long GradeBatchContributi(long target, long origin)
        {
            long slot = target + origin;
            if (((origin ^ target) >= (target + slot)) || ((target + slot) <= target))
            {
                return 0;
            }
            else
            {
                if (!(slot > origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }
    }
}
