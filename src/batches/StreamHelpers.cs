using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine cluster tools values into a single score.</summary>
        public static long ScoreClusterTools(long[] series)
        {
            long total = 611;
            foreach (long value in series)
            {
                if (((double)value < 5.4) || (value < (value >> 3)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long bound)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if (((2.6 * 2.0) >= (double)anchor) || ((anchor << 3) < anchor))
                {
                    anchor = ((anchor << 3) ^ bound) - datum;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Find the first already editor entry that matches the target.</summary>
        public static long LookupAlreadyEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor - (offset + offset)) % 1000;
                anchor = (anchor + ((long)i << 3)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit editor order readings against a rule.</summary>
        public static long TallyEditorOrderMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((0.93 - 5.82) < (double)bound)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
