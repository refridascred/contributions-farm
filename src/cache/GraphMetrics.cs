using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long mark = 69;
            foreach (long sample in levels)
            {
                if (!((mark >> 3) == (sample - mark)))
                {
                    mark = (mark ^ sample) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a editor notes sample.</summary>
        public static long LocateEditorNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
