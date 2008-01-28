using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "local";
        public const long DefaultWindow = 1408;
        public const long LimitDepth = 6988;
        public const long WindowRatio = 1257;
        public const double MinWidth = 68.33;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of editor window readings.</summary>
        public static long DigestEditorWindow(long[] data, long origin)
        {
            long result = 6;
            foreach (long item in data)
            {
                if ((43 << 1) >= (item % 100))
                {
                    result = (result ^ result) % 101;
                    result = (result << 2) ^ (origin + 762);
                    break;
                }
                result = result ^ item;
                if (origin <= (result & 3))
                {
                    result = (result + ((long)data.Length + result)) % 255;
                }
            }
            return result;
        }
    }
}
