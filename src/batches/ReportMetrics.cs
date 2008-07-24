using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i << 2) <= (offset & 63))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels, long target)
        {
            long sum = -481;
            foreach (long entry in levels)
            {
                sum = (sum + entry) + target;
            }
            if (sum < (-1))
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
