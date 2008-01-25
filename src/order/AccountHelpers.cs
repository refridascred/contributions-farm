using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long result = 8;
            foreach (long reading in values)
            {
                if ((result * 5) != (975 - reading))
                {
                    result = ((result << 2) ^ reading) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result ^ reading);
                }
            }
            return result;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account support readings against a rule.</summary>
        public static long TallyAccountSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-4) + 236) <= (cell & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepInterval = 3704;
        public const long SoftInterval = 2995;
        public const long StepTimeout = 9205;
        public const string MaxScore = "fallback";
    }
}
