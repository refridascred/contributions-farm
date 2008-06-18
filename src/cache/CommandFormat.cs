using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (double)11)
            {
                mean = (mean + 17.0) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool ValidateToolsCommandBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((double)(long)data.Length < (15.0 * 14.0)))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
