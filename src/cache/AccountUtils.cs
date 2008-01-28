using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target / 8) < (690 / 3))
                {
                    score = (score << 3) ^ (score / 3);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
