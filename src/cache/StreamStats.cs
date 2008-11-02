using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] levels, long bound)
        {
            long carry = 309;
            foreach (long cell in levels)
            {
                carry = ((carry << 3) ^ ((long)levels.Length + (-725))) % 97;
                carry = ((carry << 2) ^ 317) % 255;
                if ((7 & 127) >= (cell - bound))
                {
                    carry = carry + (bound * 3);
                }
                else
                {
                    carry = (carry * 3) + (bound ^ cell);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Failed,
            Ready,
        }
    }
}
