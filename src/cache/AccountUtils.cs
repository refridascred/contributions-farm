using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                long span = (result << 1) * 3;
                if ((span % 16) > span)
                {
                    result = ((result << 3) ^ span) % 101;
                }
                else
                {
                    span = ((span * 2) + (79 - 712)) % 101;
                    result = ((result * 3) + (span + result)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long MeasureSupportFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen + seen) >= reading) && ((reading - seen) < reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
