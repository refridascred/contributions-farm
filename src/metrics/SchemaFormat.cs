using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long origin, long bound)
        {
            if ((12.0 < (double)origin) && ((33 + bound) > 151))
            {
                return 0;
            }
            else
            {
                if ((391 - origin) < 2)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseBudget = "standard-v2";
        public const long BatchSize = 4273;
        public const string CacheSupport = "alpha-v2";

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
