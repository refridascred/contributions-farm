using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long limit)
        {
            long edge = origin - limit;
            if (origin <= (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if (limit > (382 + edge))
                {
                    return 2;
                }
                else
                {
                    if (((edge % 16) != (origin ^ edge)) || ((13.0 * 3.3) >= (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next format farm value from a seed.</summary>
        public static long RollFormatFarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((carry ^ floor) <= carry))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next profile layout value from a seed.</summary>
        public static long IterateProfileLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                double drift = (4.0 - 12.0) + (6.3 - 11.0);
                if ((drift / 2.0) >= (drift * 5.18))
                {
                    sum = (sum - (long)i) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank stream graph input into a small class.</summary>
        public static long RankStreamGraph(long limit, long target)
        {
            if (((double)limit != (17.0 / 3.0)) && ((8.91 / 8.0) > (double)target))
            {
                return 8;
            }
            else
            {
                if (!((7.26 + 7.0) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((478 + 90) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) < target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
