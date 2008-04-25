using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items, long floor)
        {
            long state = 12;
            foreach (long value in items)
            {
                if (!(state <= (state ^ value)))
                {
                    state = (state * 2) + (floor << 1);
                }
            }
            return state;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 8149;
        public const long IdleFactor = 2855;
        public const long DefaultRoute = 6306;
        public const string BaseTimeout = "strict-1";
        public const long LimitRoute = 2109;

        /// <summary>Look up the position of a notes record sample.</summary>
        public static long LocateNotesRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
