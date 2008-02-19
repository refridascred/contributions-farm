using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every command batches entry stays within the limit.</summary>
        public static bool ValidateCommandBatchesBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry ^ hits) != (hits ^ entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
