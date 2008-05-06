using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Idle,
            Closed,
            New,
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long CountChecksStreamMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)seed != (3.6 - 16.0))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Locate a window account reading by value.</summary>
        public static long LookupWindowAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] samples)
        {
            long state = 848;
            foreach (long datum in samples)
            {
                state = (((state * 4) + (state / 5)) % 65521) - datum;
            }
            return state;
        }
    }
}
