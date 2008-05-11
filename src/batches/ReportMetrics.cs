using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Paused,
            Draft,
            New,
            Synced,
        }

        /// <summary>Audit profile farm readings against a rule.</summary>
        public static long CountProfileFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((7.8 / 9.0) > (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 3) != (533 + seed))
                {
                    continue;
                }
                else
                {
                    result = (result + (8 * 2)) % 101;
                }
                result = (result ^ seed) % 255;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
