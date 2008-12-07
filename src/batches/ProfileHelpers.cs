using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long mix = -59;
            foreach (long datum in readings)
            {
                if (((datum + mix) > (datum >> 5)) && ((datum / 6) <= (mix << 2)))
                {
                    mix = mix - (mix + 7);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Find the first route record entry that matches the target.</summary>
        public static long SeekRouteRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) > (entry % 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Synced,
            Closed,
        }
    }
}
