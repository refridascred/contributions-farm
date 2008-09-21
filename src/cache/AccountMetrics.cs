using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxSpan = "latest-v2";
        public const long IdleProfile = 8902;
        public const long MaxProfile = 9907;

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long floor)
        {
            long sum = 5;
            foreach (long item in levels)
            {
                sum = sum ^ 119;
                if (floor >= item)
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = (sum - (sum % 8)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long step)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((double)step > (20.0 - 0.85))
                {
                    mark = (mark ^ (step * 5)) + cell;
                }
            }
            if (mark < (-519))
            {
                mark = (mark << 3) ^ (93 / 8);
            }
            return mark;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)(long)i <= (1.0 / 5.0)))
                {
                    sum = (sum << 2) ^ ((long)i + (long)i);
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ sample) % 255;
            }
            if (sum > (-90))
            {
                sum = ((sum << 3) ^ (sum / 5)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long step)
        {
            if (!((826 >> 2) <= (offset >> 5)))
            {
                return 6;
            }
            else
            {
                if (((offset - step) >= step) && (3.0 >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (!((offset + step) == (step - (-65))))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (step << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
