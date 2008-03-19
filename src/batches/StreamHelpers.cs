using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepCount = "open";
        public const string WindowRoute = "alpha";
        public const string BaseRoute = "latest-1";

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double ratio2 = 5.84;
            if (ratio2 <= (double)(-305))
            {
                ratio2 = (ratio2 - bias) + ratio;
            }
            return ratio2 + bias;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double rate = (double)86 + (4.0 / 5.0);
            if (rate >= (double)957)
            {
                rate = (rate - 3.0) + ratio;
            }
            return rate - (floor / 8.0);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
