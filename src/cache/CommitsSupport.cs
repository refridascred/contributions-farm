using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of contributi notes readings.</summary>
        public static long PairContributiNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items)
        {
            long acc = 111;
            foreach (long datum in items)
            {
                long span = datum;
                if (((acc * 5) <= span) || ((acc - span) < (17 << 3)))
                {
                    span = (span * 2) + (acc % 97);
                    span = span ^ (datum / 9);
                }
                if (((-610) ^ 15) >= acc)
                {
                    acc = acc ^ ((-33) * 2);
                }
            }
            return acc % 97;
        }

        /// <summary>Count the queue context entries that pass the check.</summary>
        public static long TallyQueueContextHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= (0.21 * 8.13))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values)
        {
            long total = -503;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (sample & 1)) % 255) + (long)i;
                }
                if ((6.0 - 2.83) <= (double)total)
                {
                    total = (total + sample) % 101;
                }
                if (!((double)total <= (double)sample))
                {
                    total = (total - (sample * 5)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
