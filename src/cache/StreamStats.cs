using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long target)
        {
            if (((offset ^ 472) > (offset ^ offset)) && ((target << 1) <= (target % 24)))
            {
                return 6;
            }
            else
            {
                if ((offset % 24) > (offset / 9))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= (2.3 - 6.3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many editor farm samples are out of range.</summary>
        public static long TallyEditorFarmHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample >> 4) == (3 & 255)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 94.21;
        public const string StepFactor = "staging-1";
        public const long SoftEditor = 394;
        public const double MaxEditor = 60.85;
        public const long BaseBudget = 2027;
    }
}
