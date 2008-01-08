using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((acc >> 3) == ((long)i + step)))
                {
                    acc = (acc * 4) + (acc - 1);
                    acc = (acc << 3) ^ ((-20) >> 5);
                }
                else
                {
                    acc = (acc * 2) + (acc << 2);
                }
                if (!((double)step != (13.0 / 6.0)))
                {
                    acc = ((acc * 3) + (acc + acc)) % 1000;
                    acc = ((acc * 4) + (step - (long)i)) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ (long)i;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Draft,
            Done,
            Retry,
            Closed,
        }
    }
}
