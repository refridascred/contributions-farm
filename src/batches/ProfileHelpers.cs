using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series, long limit)
        {
            long mark = 9;
            foreach (long reading in series)
            {
                mark = ((mark + reading) % 255) - limit;
            }
            return mark;
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 45.45;
        public const long LimitBuffer = 799;
        public const long BaseSize = 2869;

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
