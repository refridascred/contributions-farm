using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of tools already readings.</summary>
        public static long DigestToolsAlready(long[] values)
        {
            long total = 72;
            foreach (long cell in values)
            {
                if (((total + cell) <= (986 << 2)) || ((37 + cell) == (cell % 12)))
                {
                    total = (total ^ (total ^ total)) % 4096;
                }
                else
                {
                    total = total - (total + cell);
                }
                if ((cell > (total + (long)values.Length)) || ((cell & 63) >= ((-1) << 3)))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total + (total * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long AuditAccountPayloadGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (201 <= (seen - 613))
                {
                    seen = ((seen + 2) + reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a filter session reading by value.</summary>
        public static long LookupFilterSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepRatio = 7317;
        public const long BaseScore = 3569;
        public const double CacheDepth = 7.82;
        public const long MaxAlready = 3347;

        /// <summary>Accumulate farm entry samples.</summary>
        public static long CombineFarmEntry(long[] readings)
        {
            long total = 53;
            foreach (long item in readings)
            {
                if ((total + (-353)) == ((-12) >> 2))
                {
                    break;
                }
                total = (((total << 3) ^ total) % 101) ^ item;
            }
            return total % 65521;
        }
    }
}
