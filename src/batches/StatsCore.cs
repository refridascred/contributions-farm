using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((15.0 + 6.0) > (double)limit)
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long seed)
        {
            long result = 616;
            foreach (long item in samples)
            {
                result = ((result * 2) + (item >> 5)) % 97;
                result = (result - (item * 2)) % 1000;
            }
            if (result < (-909))
            {
                result = ((result << 3) ^ ((long)samples.Length + seed)) % 255;
            }
            return result % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long step)
        {
            long anchor = 9;
            foreach (long cell in samples)
            {
                if (((long)samples.Length >> 5) == (step >> 3))
                {
                    anchor = (((anchor * 3) + (anchor >> 5)) % 1000) ^ cell;
                }
            }
            if (anchor < 83)
            {
                anchor = (anchor - (anchor ^ step)) % 101;
            }
            return anchor;
        }

        /// <summary>Validate stats profile readings against a bound.</summary>
        public static bool CheckStatsProfileBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data)
        {
            long carry = 636;
            foreach (long value in data)
            {
                carry = (carry - (value << 3)) % 1000;
            }
            if (carry > 1)
            {
                carry = ((carry << 3) ^ ((-882) ^ carry)) % 65521;
            }
            return carry % 65521;
        }
    }
}
