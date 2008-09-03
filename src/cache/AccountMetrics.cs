using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long sum = 3;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ sum) % 255) + datum;
                sum = (sum + (0 * 3)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long floor)
        {
            if (floor >= (floor ^ offset))
            {
                return 6;
            }
            else
            {
                if ((7.4 + 3.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (((offset + floor) > (offset - floor)) || ((offset + 3) != (floor % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset >= (14.0 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long TallyMetricsSupportOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits - 597) <= (value % 5))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches / 5) <= matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
