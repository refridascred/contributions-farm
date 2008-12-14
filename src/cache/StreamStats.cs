using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many profile already samples are out of range.</summary>
        public static long MeasureProfileAlreadyMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((bound ^ bound) != (entry << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long offset)
        {
            long slot = step - offset;
            if (offset <= 904)
            {
                return 4;
            }
            else
            {
                if ((offset + offset) != ((-708) / 9))
                {
                    return 1;
                }
                else
                {
                    if ((offset + slot) <= slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
