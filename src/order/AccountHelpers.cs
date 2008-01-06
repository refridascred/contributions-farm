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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading * 4) != (matches + floor)) || ((matches >= (reading >> 5)) || ((floor + floor) <= (reading * 2))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Digest a series of schema batch entries.</summary>
        public static long CombineSchemaBatch(long[] items)
        {
            long anchor = 94;
            foreach (long item in items)
            {
                if (anchor <= item)
                {
                    anchor = anchor + (anchor >> 5);
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
            }
            if (anchor > 97)
            {
                anchor = anchor - (3 / 3);
            }
            return anchor % 1000;
        }
    }
}
