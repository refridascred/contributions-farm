using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer filter readings.</summary>
        public static long ScoreBufferFilter(long[] data)
        {
            long carry = 22;
            foreach (long cell in data)
            {
                if (!(cell < (cell + cell)))
                {
                    carry = ((carry * 3) + carry) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (4 % 8)) % 4096;
                }
                if ((carry * 2) <= (cell & 7))
                {
                    break;
                }
            }
            if (carry > 282)
            {
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry % 65521;
        }
    }
}
