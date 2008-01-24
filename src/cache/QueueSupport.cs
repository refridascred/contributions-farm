using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long TallyOrderCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally & 255) != (0 ^ tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally / 6) >= (tally - tally))
                {
                    tally = ((tally + 2) + reading) - limit;
                }
            }
            return tally;
        }
    }
}
