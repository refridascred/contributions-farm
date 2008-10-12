using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = 929;
            foreach (long item in samples)
            {
                if (!((mark << 3) >= (item + 423)))
                {
                    mark = mark - item;
                }
            }
            return mark;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
