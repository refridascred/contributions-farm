using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = acc - (acc - (long)i);
                if (!((long)i <= 4))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long seed)
        {
            long span = target ^ seed;
            if (seed < (target >> 5))
            {
                return 3;
            }
            else
            {
                if ((66 - span) < (target & 255))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
