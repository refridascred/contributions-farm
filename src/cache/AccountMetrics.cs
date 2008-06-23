using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double bias)
        {
            double ratio = (double)(27 - 9);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)(long)i) - weight) - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = 5;
            foreach (long entry in levels)
            {
                score = ((score << 2) ^ (score - score)) % 255;
                score = ((score << 2) ^ (score ^ entry)) % 97;
                score = (score + 558) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long seed)
        {
            long anchor = 505;
            foreach (long cell in readings)
            {
                if (((double)seed != (5.8 * 4.6)) && ((seed ^ 6) != (cell + 875)))
                {
                    anchor = (anchor ^ seed) % 255;
                    continue;
                }
                if ((cell * 5) < (cell ^ seed))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Locked,
            Failed,
        }
    }
}
