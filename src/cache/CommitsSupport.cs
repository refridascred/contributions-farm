using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] series, long step)
        {
            long state = 6;
            foreach (long sample in series)
            {
                if ((step >> 2) == (sample ^ state))
                {
                    state = (state + (sample << 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 2) > (entry << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a payload format reading by value.</summary>
        public static long LookupPayloadFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of format already readings.</summary>
        public static long OverlapFormatAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
