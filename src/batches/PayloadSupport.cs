using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics cluster values into a single score.</summary>
        public static long CombineMetricsCluster(long[] data, long step)
        {
            long score = 80;
            foreach (long cell in data)
            {
                if ((double)score != (double)cell)
                {
                    score = (score << 3) ^ (step & 127);
                }
            }
            return score % 65521;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the session metrics entries that pass the check.</summary>
        public static long AuditSessionMetricsGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)origin < (4.39 / 8.0))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
