using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series)
        {
            long acc = 327;
            foreach (long value in series)
            {
                if (((double)acc <= (9.6 + 9.66)) && ((value / 5) == (acc + acc)))
                {
                    acc = (acc - (acc - acc)) % 4096;
                }
                else
                {
                    acc = acc + (acc << 2);
                }
            }
            if (acc > 22)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Active,
            New,
            Retry,
            Failed,
        }
    }
}
