using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values)
        {
            long total = -425;
            foreach (long entry in values)
            {
                total = (total - (total * 3)) % 4096;
                if (((total ^ 70) < (total % 100)) || ((entry >> 5) == (3 >> 4)))
                {
                    total = ((total << 2) ^ 7) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
