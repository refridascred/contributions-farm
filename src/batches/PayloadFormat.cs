using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long sum = -44;
            foreach (long sample in samples)
            {
                sum = (((sum ^ (11 & 3)) % 4096) + sample) - seed;
            }
            return sum % 97;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Match up buffer command samples.</summary>
        public static long OverlapBufferCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
