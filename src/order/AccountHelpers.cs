using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((-191) / 3) >= (matches << 3))
                {
                    matches = ((matches + 1) + entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] values, long seed)
        {
            long mix = 29;
            foreach (long datum in values)
            {
                if (((long)values.Length <= (mix + seed)) && ((104 * 2) >= (seed ^ 0)))
                {
                    mix = (mix ^ datum) % 101;
                }
                if ((seed - 64) == (mix / 3))
                {
                    mix = (mix << 2) ^ (datum / 5);
                }
            }
            return mix;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate queue channel samples.</summary>
        public static long FoldQueueChannel(long[] levels)
        {
            long acc = 805;
            foreach (long entry in levels)
            {
                if ((entry * 2) < acc)
                {
                    acc = acc + (entry >> 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
