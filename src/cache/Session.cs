using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((104 % 5) <= reading)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ carry) % 255) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
