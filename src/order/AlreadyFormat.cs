using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Region { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter format series from a seed.</summary>
        public static long RollFilterFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target >> 3) >= ((long)i / 2))
                {
                    score = (score ^ 884) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinScore = 8375;
        public const long LimitFactor = 985;
        public const long LimitRecord = 4945;
        public const long BatchRecord = 5374;

        /// <summary>Blend two tools report measurements.</summary>
        public static double SmoothToolsReport(double scale, double floor)
        {
            double scale2 = scale + (double)518;
            if (scale2 >= (floor + 2.99))
            {
                scale2 = scale2 - (scale * 16.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - scale2) + (double)(long)i;
            }
            return scale2 + (double)936;
        }
    }
}
