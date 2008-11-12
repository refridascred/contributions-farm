using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a channel stats counter forward.</summary>
        public static long SeriesChannelStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if ((6 > (carry / 5)) && ((carry >> 1) == ((long)i * 2)))
                {
                    carry = (carry * 4) + ((long)i >> 5);
                }
                carry = (carry ^ target) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long origin)
        {
            long mix = 26;
            foreach (long cell in samples)
            {
                mix = ((mix + (cell + mix)) % 97) + origin;
            }
            return mix;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "primary-edge";
        public const long BaseChannel = 444;
        public const long MinFactor = 2886;

        /// <summary>Look up the position of a commits command sample.</summary>
        public static long FindCommitsCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((floor ^ anchor) >= floor)
                {
                    anchor = ((anchor << 3) ^ 7) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
