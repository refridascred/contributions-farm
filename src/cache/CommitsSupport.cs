using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long bound)
        {
            long total = 4;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((((total * 5) + total) % 255) + (long)i) + bound;
                }
                total = (total - value) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings, long step)
        {
            long total = 83;
            foreach (long entry in readings)
            {
                if ((entry << 3) < total)
                {
                    total = (total ^ (entry - entry)) % 101;
                }
                if ((942 >> 4) > (step >> 3))
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 34)
            {
                total = ((total * 5) + 11) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
