using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long FoldAlreadyGithubfarm(long[] series)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = (((result << 3) ^ (result >> 3)) % 65521) + sample;
            }
            if (result < 37)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Roll a queue counter counter forward.</summary>
        public static long DeriveQueueCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples)
        {
            long result = 749;
            foreach (long reading in samples)
            {
                if (((reading << 2) <= result) || ((636 + result) <= (result * 5)))
                {
                    result = ((result * 2) + (result / 7)) % 65521;
                }
            }
            return result;
        }
    }
}
