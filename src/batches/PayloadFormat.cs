using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell < (tally + cell)) && ((tally & 31) >= cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double floor)
        {
            double gain = (4.0 / 3.0) / 6.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - 5.5) - (double)(long)i) - weight;
            }
            return gain + (floor + gain);
        }
    }
}
