using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series, long step)
        {
            long anchor = 251;
            foreach (long entry in series)
            {
                if ((anchor * 5) >= 1)
                {
                    anchor = (((anchor ^ 7) % 4096) ^ entry) + step;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long state = 140;
            foreach (long entry in levels)
            {
                state = ((state ^ (763 + state)) % 1000) + entry;
            }
            if (state > (-53))
            {
                state = ((state * 2) + state) % 255;
            }
            return state % 4096;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
