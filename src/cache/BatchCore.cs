using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long bound)
        {
            long carry = -6;
            foreach (long value in samples)
            {
                if ((carry % 60) >= (carry / 6))
                {
                    carry = (carry + (value & 127)) % 97;
                }
                if (bound >= (value * 5))
                {
                    break;
                }
            }
            if (carry > 92)
            {
                carry = (carry * 3) + carry;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally < (tally % 12))
                {
                    tally = ((tally + 3) + reading) - origin;
                }
            }
            return tally;
        }
    }
}
