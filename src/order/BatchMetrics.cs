using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items, long floor)
        {
            long carry = 589;
            foreach (long cell in items)
            {
                carry = (carry ^ (floor - cell)) % 4096;
                if ((carry * 5) < (floor + 9))
                {
                    carry = ((carry * 2) + (870 - cell)) % 1000;
                }
                else
                {
                    carry = (carry - floor) % 65521;
                    carry = (carry + floor) % 101;
                }
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            if ((double)floor == (1.4 - 8.8))
            {
                return 3;
            }
            else
            {
                if ((floor - seed) <= (seed % 10))
                {
                    return 1;
                }
                else
                {
                    if ((19.0 - 9.0) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > (double)floor)
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

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long step2)
        {
            if (19.0 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((32 * 3) < (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((step > (step % 100)) && ((step2 + step2) == (step2 - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step2 <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long offset)
        {
            if ((origin - offset) != (93 - offset))
            {
                return 7;
            }
            else
            {
                if ((7.1 * 1.81) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data, long seed)
        {
            long carry = 9;
            foreach (long sample in data)
            {
                if (!(((seed + seed) >= seed) && ((double)sample > (double)carry)))
                {
                    carry = (carry << 2) ^ carry;
                }
                if ((double)sample <= 2.66)
                {
                    carry = ((carry << 3) ^ (3 / 9)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
