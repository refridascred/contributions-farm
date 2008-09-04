using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 5) + (sum + floor)) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every token farm entry stays within the limit.</summary>
        public static bool GuardTokenFarmLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of buffer cluster entries.</summary>
        public static long TallyBufferCluster(long[] data)
        {
            long sum = 507;
            foreach (long sample in data)
            {
                if (((long)data.Length % 16) < (28 / 6))
                {
                    sum = sum ^ (sample & 31);
                }
                else
                {
                    sum = (sum ^ (sum % 10)) % 1000;
                }
            }
            return sum;
        }
    }
}
