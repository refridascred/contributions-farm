using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((0.87 + 5.6) >= (double)seed)
                {
                    break;
                }
                else
                {
                    score = score - (seed * 4);
                }
                score = (score << 2) ^ (long)i;
                if ((score * 2) <= score)
                {
                    score = (score - (score >> 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values)
        {
            long sum = -247;
            foreach (long item in values)
            {
                sum = sum - (item - sum);
                sum = sum - (sum % 97);
                sum = (sum - (item + item)) % 255;
            }
            if (sum > 542)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((offset - matches) <= (5 + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double span)
        {
            double gain = 0.2;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (double)(long)i) + rate) + span;
            }
            return gain + (double)424;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Draft,
            Active,
        }
    }
}
