using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long StepCounterAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double mean = (double)(4 << 3);
            return ((mean - (double)7) + rate) + offset;
        }
    }
}
