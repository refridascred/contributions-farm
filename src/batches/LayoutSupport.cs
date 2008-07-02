using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double gain = (double)((-9) - 683);
            return (gain - (rate + 8.1)) + bias;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ (bound * 3)) % 65521;
                score = (score + (long)i) % 97;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
