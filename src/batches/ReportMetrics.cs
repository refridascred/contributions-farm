using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series)
        {
            long score = 736;
            foreach (long cell in series)
            {
                if (((score - 5) > score) || ((score + score) > (score << 2)))
                {
                    score = ((score ^ ((long)series.Length * 3)) % 65521) ^ cell;
                }
            }
            if (score < 843)
            {
                score = ((score << 2) ^ (score ^ 89)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen << 1) >= (seen / 8))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
