using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double scale, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = (drift + (6.8 / 8.0)) + scale;
            }
            else
            {
                drift = drift + 4.4;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (9.3 + drift);
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double offset)
        {
            double ratio = 5.3;
            if (ratio < (double)1)
            {
                ratio = ((ratio + (double)3) - gain) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long carry = 664;
            foreach (long datum in readings)
            {
                if (((8 + carry) == (carry ^ (-33))) || (carry < (carry + datum)))
                {
                    carry = (carry * 5) + (datum % 60);
                }
            }
            return carry;
        }
    }
}
