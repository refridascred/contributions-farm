using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a notes cluster sample.</summary>
        public static long FindNotesClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix + (offset + mix)) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long limit)
        {
            long state = 5;
            foreach (long cell in samples)
            {
                if ((11.0 * 2.7) != (double)state)
                {
                    state = (state ^ (cell % 2)) % 255;
                }
                else
                {
                    state = (state << 2) ^ (limit << 2);
                }
            }
            return state;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
