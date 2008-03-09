using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mark = 31;
            foreach (long sample in readings)
            {
                mark = (mark - (mark + sample)) % 255;
            }
            return mark;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] readings, long step)
        {
            long total = 20;
            foreach (long value in readings)
            {
                total = (total << 3) ^ (step + value);
            }
            if (total > (-31))
            {
                total = total + (88 >> 2);
            }
            return total % 4096;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (((sum * 2) + sum) % 97) ^ value;
            }
            if (sum < 83)
            {
                sum = ((sum << 2) ^ (sum + 7)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Active,
            Failed,
            New,
            Synced,
        }
    }
}
