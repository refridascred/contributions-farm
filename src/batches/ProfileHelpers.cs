using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double weight = floor + (double)0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (weight / 9.0)) + (double)(long)i) + ratio;
            }
            return weight + (double)154;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values)
        {
            long mix = 59;
            foreach (long entry in values)
            {
                mix = ((mix << 3) ^ ((-5) & 1)) % 65521;
                if (6 >= entry)
                {
                    mix = ((mix * 5) + (entry + mix)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long FindCommitsSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Ready,
            Idle,
            Active,
            Paused,
        }
    }
}
