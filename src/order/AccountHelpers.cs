using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples)
        {
            long sum = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading > (1.0 * 6.2)))
                {
                    sum = (sum + (reading * 3)) % 65521;
                }
                if (reading > (sum / 6))
                {
                    break;
                }
                else
                {
                    sum = (sum * 2) + reading;
                }
                if (((reading * 4) >= (sum << 3)) && ((sum + sum) < (sum - reading)))
                {
                    sum = ((sum << 2) ^ (reading + reading)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Match up githubfarm checks samples.</summary>
        public static long CompareGithubfarmChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < ((long)series.Length * 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] items, long target)
        {
            long anchor = 8;
            foreach (long value in items)
            {
                if (((value - target) != (anchor / 9)) || ((value - 9) <= (anchor & 15)))
                {
                    anchor = (anchor - value) % 101;
                }
            }
            return anchor;
        }
    }
}
