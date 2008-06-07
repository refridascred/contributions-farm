using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 52;
            foreach (long item in readings)
            {
                total = (((total * 5) + total) % 255) ^ item;
            }
            if (total < 3)
            {
                total = (total << 2) ^ (total - 667);
            }
            return total;
        }

        /// <summary>Match up metric layout samples.</summary>
        public static long MatchMetricLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
