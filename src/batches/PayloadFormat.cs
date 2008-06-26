using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((4 << 3) < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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
