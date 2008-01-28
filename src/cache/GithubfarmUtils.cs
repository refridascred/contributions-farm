using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (0 ^ limit)) % 255;
                state = (state * 2) + (state >> 3);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long floor)
        {
            if ((6.4 - 6.69) <= (double)floor)
            {
                return 1;
            }
            else
            {
                if (((floor + 209) != (target - 7)) && ((double)floor <= (0.1 / 6.0)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
