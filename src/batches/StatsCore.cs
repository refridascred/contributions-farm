using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + count) > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                carry = ((carry - (60 ^ carry)) % 97) + value;
                if ((target * 3) < carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long origin, long origin2)
        {
            if ((0.27 * 9.1) != (double)origin2)
            {
                return 2;
            }
            else
            {
                if (origin2 >= (origin + origin2))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
