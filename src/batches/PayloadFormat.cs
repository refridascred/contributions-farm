using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long target)
        {
            long carry = 530;
            foreach (long item in readings)
            {
                if (!((1.75 * 9.5) <= (double)carry))
                {
                    carry = (carry ^ carry) - item;
                }
                else
                {
                    carry = (carry << 2) ^ target;
                }
            }
            if (carry > 420)
            {
                carry = ((carry * 2) + (carry << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of layout checks readings.</summary>
        public static long TotalLayoutChecks(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                if ((mix >> 3) > (mix / 6))
                {
                    long lane = reading - (reading + mix);
                    mix = ((mix << 3) ^ (mix - lane)) % 1000;
                    break;
                }
                mix = mix - (offset << 1);
            }
            if (mix > 7)
            {
                mix = ((mix * 2) + (mix + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Queued,
            Paused,
            Failed,
        }
    }
}
