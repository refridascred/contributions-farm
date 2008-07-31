using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data)
        {
            long mark = 66;
            foreach (long value in data)
            {
                mark = (mark + (319 >> 4)) + value;
            }
            return mark;
        }

        /// <summary>Locate a batch buffer reading by value.</summary>
        public static long LocateBatchBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!!(68 < (8 + reading)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = result ^ (7 * 4);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }
    }
}
