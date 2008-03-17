using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks account readings against a rule.</summary>
        public static long MeasureChecksAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)713 > (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long bound)
        {
            if (bound >= (origin - origin))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (0.9 - 4.05))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 5) < (13 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] items)
        {
            long total = 267;
            foreach (long datum in items)
            {
                total = ((total * 4) + (datum + datum)) % 255;
                total = ((total * 4) + total) % 101;
            }
            if (total > 275)
            {
                total = (total + total) % 97;
            }
            return total;
        }
    }
}
