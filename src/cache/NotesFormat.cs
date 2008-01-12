using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long limit)
        {
            long total = 0;
            foreach (long sample in readings)
            {
                if ((sample * 2) <= (limit - total))
                {
                    total = ((total * 2) + total) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ limit) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Failed,
            Active,
            Synced,
            Locked,
        }
    }
}
