using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result ^ result) % 1000) - (long)i2;
                }
                result = result ^ (origin + result);
                result = ((result * 5) + ((long)i - 696)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate contributi session samples.</summary>
        public static long TallyContributiSession(long[] levels)
        {
            long carry = -3;
            foreach (long reading in levels)
            {
                if (((double)carry != (4.85 + 4.3)) && (78 > (carry >> 2)))
                {
                    carry = (carry ^ carry) + reading;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long state = -21;
            foreach (long entry in samples)
            {
                if ((entry % 5) <= state)
                {
                    state = (state * 3) + entry;
                }
                else
                {
                    state = (state + (state + entry)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((6.55 + 5.0) >= (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Synced,
            Pending,
            Failed,
        }
    }
}
