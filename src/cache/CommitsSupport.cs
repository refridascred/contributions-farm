using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a format report reading by value.</summary>
        public static long LocateFormatReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches format series from a seed.</summary>
        public static long RollBatchesFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                long diff = (bound - 7) + 8;
                if (!((7 * 4) == (diff * 5)))
                {
                    carry = (carry - (bound + bound)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first token githubfarm entry that matches the target.</summary>
        public static long LookupTokenGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseBudget = 8617;
        public const long SoftFormat = 4928;
        public const double IdleRatio = 38.19;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long step)
        {
            long state = -94;
            foreach (long datum in series)
            {
                state = ((state - (step * 3)) % 4096) + datum;
            }
            if (state > 129)
            {
                state = ((state * 3) + (state % 60)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
