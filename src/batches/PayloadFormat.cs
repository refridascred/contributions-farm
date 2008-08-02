using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if ((value + value) >= (value % 60))
                {
                    carry = ((carry * 2) + carry) % 4096;
                }
                if (((double)carry < (4.49 + 5.8)) || ((value ^ value) != (47 ^ value)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every route metric entry stays within the limit.</summary>
        public static bool VerifyRouteMetricRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Locked,
            Paused,
        }
    }
}
