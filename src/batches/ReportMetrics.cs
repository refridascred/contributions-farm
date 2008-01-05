using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a farm checks reading by value.</summary>
        public static long SeekFarmChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series)
        {
            long state = 7;
            foreach (long datum in series)
            {
                if ((6.8 + 7.0) >= (double)5)
                {
                    state = state + (datum + state);
                }
            }
            return state % 1000;
        }
    }
}
