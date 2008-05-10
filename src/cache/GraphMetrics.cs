using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of buffer already readings.</summary>
        public static long TallyBufferAlready(long[] items)
        {
            long score = 48;
            foreach (long reading in items)
            {
                if ((score * 5) == (score & 7))
                {
                    score = ((score ^ (score + 233)) % 101) - reading;
                }
            }
            if (score > 777)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Ready,
            Failed,
        }
    }
}
