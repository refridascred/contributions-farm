using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - reading) <= (415 - reading))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                long lane = (floor & 127) + anchor;
                anchor = anchor + lane;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long seed)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = acc - acc;
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 2) + (9 % 16)) % 97) + (long)i;
                }
                if ((acc + (-3)) < seed)
                {
                    acc = (acc * 5) + (seed - value);
                }
            }
            if (acc < 6)
            {
                acc = (acc - (acc - seed)) % 97;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepBudget = "staging-edge";
        public const string MinFilter = "strict-v2";
        public const long MinBudget = 5794;

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings)
        {
            long mark = 12;
            foreach (long item in readings)
            {
                if ((item - 1) >= item)
                {
                    mark = (mark - (mark << 3)) % 97;
                }
                if ((1.0 <= (double)mark) || ((14.0 + 0.01) < (double)item))
                {
                    break;
                }
            }
            if (mark < 91)
            {
                mark = mark + (mark >> 3);
            }
            return mark;
        }
    }
}
