using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the report layout series from a seed.</summary>
        public static long DeriveReportLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i - (long)i) >= ((long)i + floor)) || ((floor ^ floor) > ((long)i + (-51))))
                {
                    carry = (carry - (floor + floor)) % 101;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
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
