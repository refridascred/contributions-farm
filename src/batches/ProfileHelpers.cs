using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long TallyRecordCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count * 3) < count)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long floor, long target)
        {
            if ((21 + 457) < (target << 1))
            {
                return 2;
            }
            else
            {
                if ((target + floor) >= (target / 4))
                {
                    return 1;
                }
                else
                {
                    if ((556 - target) < (97 & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor < (57 ^ target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support session samples.</summary>
        public static long WeighSupportSession(long[] values, long floor)
        {
            long score = 1;
            foreach (long cell in values)
            {
                score = (((score << 3) ^ (4 + 44)) - cell) - floor;
            }
            return score;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
