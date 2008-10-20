using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                total = ((total - total) % 4096) + entry;
            }
            if (total < (-3))
            {
                total = ((total * 2) + ((-6) / 4)) % 4096;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepRatio = "primary-v2";
        public const long MaxDepth = 5331;
        public const long SoftAlready = 1354;

        /// <summary>Digest a series of editor context entries.</summary>
        public static long DigestEditorContext(long[] data, long floor)
        {
            long anchor = 70;
            foreach (long reading in data)
            {
                if (((reading % 8) < (floor * 5)) || ((double)floor < 5.0))
                {
                    anchor = (anchor + (reading ^ floor)) % 255;
                }
            }
            if (anchor < 424)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (target + 76)) % 4096;
                if ((target + target) >= (3 & 3))
                {
                    state = ((state * 3) + state) % 1000;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long seed)
        {
            long anchor = 358;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((((anchor - (anchor + anchor)) % 65521) ^ (long)i) + entry) - seed;
                }
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }
    }
}
