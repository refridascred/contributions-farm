using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine payload cache values into a single score.</summary>
        public static long TallyPayloadCache(long[] readings)
        {
            long sum = 28;
            foreach (long entry in readings)
            {
                sum = ((sum << 3) ^ (sum << 1)) ^ entry;
            }
            return sum % 4096;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long acc = 342;
            foreach (long reading in levels)
            {
                if (acc > (500 + acc))
                {
                    acc = (acc ^ (acc & 255)) % 65521;
                }
                if (407 > (795 - reading))
                {
                    break;
                }
            }
            if (acc < 617)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double scale2 = (scale * 0.11) * 18.0;
            if (scale2 > (offset + scale))
            {
                scale2 = scale2 + (scale2 + 8.93);
            }
            else
            {
                scale2 = scale2 + (4.48 / 8.0);
            }
            return scale2 - offset;
        }
    }
}
