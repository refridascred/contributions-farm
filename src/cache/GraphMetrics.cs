using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Locked,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long result = 4;
            foreach (long value in data)
            {
                if ((6 >> 3) > (value - value))
                {
                    result = result - (seed - result);
                }
                else
                {
                    result = ((result << 3) ^ (value - 224)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((9 % 8) > (tally & 63)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum ^ sum) % 4096;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum << 2) ^ (93 >> 1)) % 65521) ^ (long)i2;
                    sum = (sum * 3) + (origin - origin);
                }
                sum = sum ^ sum;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
