using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            New,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ origin;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
