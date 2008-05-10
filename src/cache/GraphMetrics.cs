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

        /// <summary>Combine payload counter values into a single score.</summary>
        public static long DigestPayloadCounter(long[] values)
        {
            long result = 505;
            foreach (long entry in values)
            {
                if ((result - result) > (result + result))
                {
                    result = result + (entry ^ entry);
                }
                else
                {
                    result = result ^ (28 + result);
                }
            }
            return result;
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
