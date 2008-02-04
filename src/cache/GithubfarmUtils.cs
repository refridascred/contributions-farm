using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of payload order readings.</summary>
        public static long WeighPayloadOrder(long[] items)
        {
            long total = 5;
            foreach (long reading in items)
            {
                total = (total << 2) ^ (reading + reading);
            }
            if (total > 62)
            {
                total = ((total << 3) ^ (total - 808)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Done,
        }
    }
}
