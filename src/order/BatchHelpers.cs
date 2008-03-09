using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double weight = (double)(34 / 7);
            if (weight > weight)
            {
                weight = (weight - weight) + bias;
            }
            else
            {
                weight = weight - bias2;
            }
            return weight - (bias2 + bias2);
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Retry,
            Draft,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
