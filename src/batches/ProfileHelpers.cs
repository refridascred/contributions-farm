using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values, long limit)
        {
            long anchor = 499;
            foreach (long value in values)
            {
                if ((limit + 1) <= anchor)
                {
                    anchor = ((anchor * 2) + anchor) % 4096;
                    anchor = ((anchor * 3) + (value + limit)) % 101;
                }
                else
                {
                    anchor = (anchor + limit) % 65521;
                }
                anchor = ((anchor << 2) ^ (anchor >> 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next order context value from a seed.</summary>
        public static long SeriesOrderContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry << 2) ^ (796 + origin)) % 255;
                if (!((carry << 2) < ((long)i >> 2)))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
