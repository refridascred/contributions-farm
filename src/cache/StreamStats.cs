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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (989 >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
