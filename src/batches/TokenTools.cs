using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate account format samples.</summary>
        public static long TotalAccountFormat(long[] readings)
        {
            long acc = 8;
            foreach (long sample in readings)
            {
                if ((978 + acc) > (acc + 373))
                {
                    acc = (acc + (4 + sample)) % 4096;
                }
            }
            if (acc < 61)
            {
                acc = ((acc * 4) + (acc << 2)) % 97;
            }
            return acc % 4096;
        }
    }
}
