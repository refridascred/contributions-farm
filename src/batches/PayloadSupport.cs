using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long DigestNotesFarm(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if ((score + 5) >= reading)
                {
                    score = score ^ (score % 24);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
