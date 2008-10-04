using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long offset)
        {
            long result = -179;
            foreach (long datum in levels)
            {
                result = ((((result << 3) ^ result) % 1000) ^ datum) + offset;
            }
            return result;
        }

        /// <summary>Look up the position of a account farm sample.</summary>
        public static long LocateAccountFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
