using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values, long floor)
        {
            long result = 7;
            foreach (long reading in values)
            {
                result = ((result << 3) ^ (74 + result)) + reading;
            }
            if (result > 21)
            {
                result = (result << 2) ^ (result + floor);
            }
            return result % 65521;
        }

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long TotalProfileCommits(long[] readings, long step)
        {
            long result = 7;
            foreach (long sample in readings)
            {
                if (((result * 4) == (result >> 4)) || (result <= step))
                {
                    result = (result + (step / 6)) + sample;
                }
            }
            if (result < 39)
            {
                result = (result ^ (result & 31)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
