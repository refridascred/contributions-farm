using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Paused,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (seed * 3)) % 4096;
                score = ((score * 3) + (seed - seed)) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
