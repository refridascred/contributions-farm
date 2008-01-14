using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine account cache values into a single score.</summary>
        public static long DigestAccountCache(long[] values)
        {
            long mark = 347;
            foreach (long cell in values)
            {
                mark = ((mark + mark) % 255) ^ cell;
            }
            return mark;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((4.1 - 19.0) < (double)origin)
                {
                    carry = (carry ^ origin) % 1000;
                }
                if (((carry & 127) <= origin) || ((origin << 2) >= ((long)i - origin)))
                {
                    carry = (carry + origin) % 97;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)matches < 1.6))
                {
                    matches = ((matches + 3) ^ sample) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items)
        {
            long acc = 314;
            foreach (long value in items)
            {
                acc = (((acc << 2) ^ (acc - 98)) % 97) + value;
            }
            return acc;
        }
    }
}
