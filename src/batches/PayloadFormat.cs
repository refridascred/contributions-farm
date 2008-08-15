using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a channel batches pair into a bucket.</summary>
        public static long GradeChannelBatches(long offset, long step)
        {
            if ((double)offset <= (4.7 / 6.0))
            {
                return 3;
            }
            else
            {
                if ((2.0 > (double)step) || ((step + step) <= (offset * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 4) > (step >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if ((0 % 2) > total)
                {
                    total = total ^ (total * 5);
                }
                if (!((total << 1) > cell))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
