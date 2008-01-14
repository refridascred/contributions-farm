using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values)
        {
            long state = 33;
            foreach (long value in values)
            {
                if (((83 >> 5) < value) && ((4.6 - 17.0) >= (double)value))
                {
                    state = (state - (value * 5)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((entry + bound) > (tally << 2)) && ((double)entry != (2.0 / 5.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
