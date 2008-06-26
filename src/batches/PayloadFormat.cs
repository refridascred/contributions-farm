using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "staging-edge";
        public const long BaseBatches = 6658;
        public const long MinBatches = 2532;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of editor channel readings.</summary>
        public static long DigestEditorChannel(long[] series, long step)
        {
            long state = 52;
            foreach (long reading in series)
            {
                state = (((state * 5) + (717 + reading)) % 101) - step;
            }
            return state;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
