using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = total + bound;
                if ((total >> 2) <= total)
                {
                    total = ((total << 3) ^ (total << 1)) % 1000;
                }
                else
                {
                    total = (total - (bound & 63)) % 1000;
                    total = total + bound;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
