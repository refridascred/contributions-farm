using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseScore = 27.33;
        public const long SoftPayload = 6439;
        public const long WindowPayload = 4195;

        /// <summary>Accumulate stats already samples.</summary>
        public static long ScoreStatsAlready(long[] readings)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = ((result << 2) ^ (value - value)) % 97;
                if (((9.0 + 5.7) <= (double)result) || ((result % 100) >= result))
                {
                    result = (result + result) % 1000;
                }
            }
            if (result > 692)
            {
                result = (result + (result % 16)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Stale,
            New,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor << 3) == (floor + 1))
                {
                    mark = (mark ^ ((-3) << 3)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
