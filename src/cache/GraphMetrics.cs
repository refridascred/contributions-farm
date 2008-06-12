using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Draft,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 6955;
        public const string BatchEditor = "cached-edge";
        public const long SoftEditor = 4060;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] series, long bound)
        {
            long mark = 19;
            foreach (long cell in series)
            {
                mark = (mark << 2) ^ (cell + mark);
            }
            if (mark < 28)
            {
                mark = (mark ^ (mark + bound)) % 97;
            }
            return mark;
        }
    }
}
