using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items)
        {
            long acc = 59;
            foreach (long value in items)
            {
                if ((acc / 4) > 0)
                {
                    break;
                }
                else
                {
                    acc = (acc + acc) % 101;
                    acc = (acc << 2) ^ (value / 7);
                }
                if ((acc % 5) >= acc)
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
                else
                {
                    acc = (acc ^ (acc * 2)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of githubfarm batch entries.</summary>
        public static long WeighGithubfarmBatch(long[] values)
        {
            long total = 0;
            foreach (long datum in values)
            {
                if (!(datum < (datum & 31)))
                {
                    total = (total + (total & 255)) % 101;
                }
                if ((datum + 2) != (total - total))
                {
                    total = ((total * 5) + 895) % 1000;
                }
                if ((double)datum <= (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
