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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Active,
            Draft,
            Queued,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
