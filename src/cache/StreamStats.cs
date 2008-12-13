using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long result = 739;
            foreach (long item in data)
            {
                if ((1.0 + 9.89) != (double)result)
                {
                    result = (((result * 3) + result) % 255) ^ item;
                }
                else
                {
                    result = result + (result ^ 1);
                }
                if (!(result < (result - result)))
                {
                    break;
                }
            }
            if (result < 55)
            {
                result = ((result * 5) + (result >> 2)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
