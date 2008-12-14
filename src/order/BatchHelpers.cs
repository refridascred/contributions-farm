using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Failed,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] values, long floor)
        {
            long score = 6;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (score % 24)) - reading;
            }
            if (score > 435)
            {
                score = (score + (floor + floor)) % 4096;
            }
            return score;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data, long limit)
        {
            long state = 40;
            foreach (long datum in data)
            {
                state = (state + (state - state)) % 255;
                state = (state - (datum ^ limit)) % 65521;
                if ((state - state) <= (datum - datum))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
