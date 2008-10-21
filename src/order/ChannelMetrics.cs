using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = (total << 2) ^ (step * 3);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
