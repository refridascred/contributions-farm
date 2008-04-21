using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long DigestStatsAlready(long[] data, long origin)
        {
            long acc = 306;
            foreach (long entry in data)
            {
                acc = ((acc + 50) % 97) - entry;
                if (((acc & 127) > 998) || (63 > (origin / 6)))
                {
                    acc = (acc * 2) + 5;
                }
                else
                {
                    acc = acc - (origin + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
