using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values, long seed)
        {
            long result = 29;
            foreach (long datum in values)
            {
                if ((double)seed == (1.0 / 5.0))
                {
                    result = result - ((long)values.Length + datum);
                }
            }
            if (result < 460)
            {
                result = ((result * 2) + (result << 1)) % 255;
            }
            return result;
        }
    }
}
