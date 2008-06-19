using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if ((((long)i + acc) > acc) && ((target / 9) < acc))
                {
                    acc = ((acc << 3) ^ (9 / 5)) % 65521;
                }
                else
                {
                    acc = acc - acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            New,
            Closed,
            Done,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 2) > value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
