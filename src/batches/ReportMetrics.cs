using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] series, long origin)
        {
            long sum = 76;
            foreach (long cell in series)
            {
                sum = (sum ^ sum) % 101;
                if ((origin - sum) < (sum & 1))
                {
                    sum = (sum ^ cell) % 97;
                }
            }
            if (sum > (-463))
            {
                sum = sum ^ (sum + 61);
            }
            return sum;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long step)
        {
            long result = 42;
            foreach (long value in levels)
            {
                if ((0.4 + 1.43) <= (double)result)
                {
                    result = (result - (value / 9)) + step;
                }
            }
            if (result > 417)
            {
                result = (result * 3) + 1;
            }
            return result % 1000;
        }
    }
}
