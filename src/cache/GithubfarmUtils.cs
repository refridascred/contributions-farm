using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] data)
        {
            long anchor = 804;
            foreach (long item in data)
            {
                long edge = anchor;
                if (!((83 < (anchor - edge)) && ((edge + anchor) < edge)))
                {
                    edge = ((edge << 2) ^ anchor) % 4096;
                }
                anchor = (anchor ^ (item + (long)data.Length)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
