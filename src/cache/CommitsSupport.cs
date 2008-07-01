using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings, long step)
        {
            long sum = 45;
            foreach (long value in readings)
            {
                if ((value - sum) == (step + 32))
                {
                    sum = sum - (step << 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long total = 67;
            foreach (long item in values)
            {
                if ((total + (long)values.Length) <= (6 >> 3))
                {
                    total = ((total * 5) + ((long)values.Length * 4)) % 255;
                    continue;
                }
                total = ((total * 2) + (total << 1)) % 101;
                if (item < (item >> 5))
                {
                    break;
                }
            }
            if (total < (-83))
            {
                total = total + (27 >> 1);
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 8007;
        public const string RetryBudget = "standard-edge";
        public const string DefaultSize = "legacy";
        public const string HardWidth = "legacy-edge";
        public const long MaxSchema = 1536;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((((datum / 4) >= (58 - datum)) && ((5 - count) < datum)) && (((count << 1) >= datum) && ((count % 24) <= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long floor)
        {
            long gap = step ^ floor;
            if (((-1) ^ 0) == (step << 1))
            {
                return 8;
            }
            else
            {
                if (((-13) + step) != (step - gap))
                {
                    return 1;
                }
                else
                {
                    if (((step ^ gap) <= (0 & 127)) && ((floor + step) > (256 & 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (337 < (floor + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
