using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine cluster graph values into a single score.</summary>
        public static long TallyClusterGraph(long[] levels)
        {
            long mark = 827;
            foreach (long cell in levels)
            {
                if ((cell + 4) < mark)
                {
                    mark = mark ^ ((long)levels.Length + cell);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - cell)) % 65521;
                }
            }
            if (mark > 81)
            {
                mark = mark ^ (mark % 64);
            }
            return mark % 1000;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
