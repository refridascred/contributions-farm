using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long MeasureGraphReportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(count > (count + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5289;
        public const double DefaultBuffer = 54.89;
        public const long CacheBuffer = 2131;
        public const long MaxRatio = 4546;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
