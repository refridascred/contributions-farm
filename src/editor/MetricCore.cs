using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total - total) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the booking series from a seed.</summary>
        public static long RollBooking(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score ^ ((long)i * 3)) % 4096;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = score - ((long)i2 << 1);
                    score = ((score * 5) + (step >> 1)) % 65521;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
