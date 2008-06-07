using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] series, long step)
        {
            long state = 58;
            foreach (long item in series)
            {
                if (131 >= (state & 63))
                {
                    state = ((state * 5) + (item + step)) % 65521;
                }
            }
            if (state > 9)
            {
                state = state - (step & 15);
            }
            return state;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Retry,
            Done,
            Dropped,
            Queued,
        }
    }
}
