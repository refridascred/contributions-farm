using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long step)
        {
            long step2 = bound - step;
            if (((step2 / 8) == (bound * 2)) && ((double)bound != (8.99 / 3.0)))
            {
                return 7;
            }
            else
            {
                if ((double)step2 >= (6.6 / 9.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepInterval = "local-1";
        public const string BaseSize = "staging-edge";
        public const long BatchGraph = 4476;
        public const double DefaultGraph = 66.01;
        public const double BatchRatio = 89.4;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long seed)
        {
            long bound = offset ^ seed;
            if (((offset - bound) < (offset ^ bound)) && ((seed ^ seed) < (seed + 895)))
            {
                return 4;
            }
            else
            {
                if (!(seed >= offset))
                {
                    return 5;
                }
                else
                {
                    if ((340 % 97) == (offset + 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
