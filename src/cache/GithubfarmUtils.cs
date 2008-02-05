using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
