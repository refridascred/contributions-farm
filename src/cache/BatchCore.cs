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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double load = 6.32 * 10.0;
            return ((load + 1.0) + bias) + floor;
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
