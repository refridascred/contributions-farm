using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long offset)
        {
            long step2 = step + offset;
            if (step <= (step2 & 127))
            {
                return 2;
            }
            else
            {
                if ((819 + step2) > step)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double weight2 = 19.0;
            if (weight2 > (weight2 - 7.8))
            {
                weight2 = weight2 + (weight / 5.0);
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (5.4 + weight)) + (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
