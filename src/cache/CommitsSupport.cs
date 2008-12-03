using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long floor2)
        {
            if ((93 & 7) > floor2)
            {
                return 4;
            }
            else
            {
                if (((floor2 << 2) >= (floor << 2)) && ((double)floor2 >= (9.5 * 1.47)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double bias2 = (floor + floor) + (double)(-348);
            if (bias2 <= (floor * 3.81))
            {
                bias2 = (bias2 + (floor / 7.0)) + bias;
            }
            return bias2 + 3.7;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((31 / 9) < (datum + count)))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
