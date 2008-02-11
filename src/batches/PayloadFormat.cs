using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < gain2)
            {
                gain2 = (gain2 + (14.0 + offset)) + gain;
            }
            else
            {
                gain2 = gain2 + (gain2 - gain2);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - (offset - 1.0);
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + (offset + (long)i)) % 97;
                if ((offset - sum) > sum)
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
