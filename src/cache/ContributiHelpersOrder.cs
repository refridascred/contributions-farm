using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] values, long origin)
        {
            long sum = 167;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ (968 + (-9))) + value) + origin;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
