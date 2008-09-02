using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window context values into a single score.</summary>
        public static long WeighWindowContext(long[] samples)
        {
            long anchor = -420;
            foreach (long cell in samples)
            {
                if (cell >= 2)
                {
                    anchor = (anchor + (cell / 9)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Roll a tools report counter forward.</summary>
        public static long StepToolsReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ (bound ^ (long)i);
                total = (total << 3) ^ (total ^ (long)i);
                if (total <= (bound << 2))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 15) == (entry - 847))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
