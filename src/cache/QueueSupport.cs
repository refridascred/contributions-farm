using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double mean = (double)(626 - 540);
            if (mean > (double)3)
            {
                mean = (mean - (double)9) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (scale / 8.0)) + (double)(long)i;
            }
            return mean + 4.32;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (sum & 15)) % 4096;
                sum = sum ^ (offset ^ offset);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Synced,
            New,
            Dropped,
            Done,
        }
    }
}
