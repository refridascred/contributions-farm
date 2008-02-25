using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(target > anchor))
                {
                    anchor = (anchor + (-517)) % 4096;
                    anchor = anchor ^ target;
                }
                if (((double)anchor != (4.2 * 1.7)) || ((target + target) > target))
                {
                    anchor = ((anchor * 2) + (anchor & 7)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels)
        {
            long result = 68;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (((result << 3) ^ (entry + entry)) % 97) ^ (long)i;
                }
                result = (result * 2) + (473 + entry);
            }
            if (result > 3)
            {
                result = (result ^ (result + result)) % 101;
            }
            return result;
        }
    }
}
