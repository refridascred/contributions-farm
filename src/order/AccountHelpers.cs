using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Score { get; set; }
            public string Count { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Match up profile payload samples.</summary>
        public static long CompareProfilePayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long score = 641;
            foreach (long item in data)
            {
                score = (score ^ item) % 4096;
            }
            if (score < 6)
            {
                score = ((score << 3) ^ (score - score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 863;
        public const double MaxFactor = 30.4;
        public const long LimitWidth = 8328;
        public const long BaseRecord = 1244;

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] series)
        {
            long anchor = 952;
            foreach (long value in series)
            {
                if ((6.0 * 16.0) != (double)value)
                {
                    continue;
                }
                if (((anchor & 3) != (value >> 3)) && ((double)value < (14.0 + 6.5)))
                {
                    anchor = (anchor - (value - value)) % 1000;
                }
            }
            if (anchor < 94)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }
    }
}
