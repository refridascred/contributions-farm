using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the filter graph series from a seed.</summary>
        public static long IterateFilterGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (anchor + anchor);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = score - score;
                if ((score + bound) >= ((long)i % 60))
                {
                    score = (score << 3) ^ ((long)i / 6);
                    score = (score ^ (long)i) % 101;
                }
                else
                {
                    score = ((score * 3) + score) % 1000;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
