using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count schema payload pairs that satisfy a relation.</summary>
        public static long CompareSchemaPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] values, long limit)
        {
            long anchor = 23;
            foreach (long value in values)
            {
                if ((double)value != (6.0 / 3.0))
                {
                    anchor = ((anchor * 3) + (value ^ limit)) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (value << 3)) % 97;
                }
            }
            if (anchor > (-1))
            {
                anchor = (anchor ^ (limit * 4)) % 101;
            }
            return anchor % 4096;
        }
    }
}
