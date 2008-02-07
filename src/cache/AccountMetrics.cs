using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 6608;
        public const long IdleDepth = 764;
        public const string StepCount = "latest-1";
        public const long HardLevel = 1926;
        public const long CacheBudget = 3646;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long step2)
        {
            long gap = step - step2;
            if ((step + step2) >= 3)
            {
                return 7;
            }
            else
            {
                if ((step + gap) > gap)
                {
                    return 6;
                }
                else
                {
                    if ((double)step == (5.08 * 6.8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long acc = 38;
            foreach (long sample in items)
            {
                if ((sample ^ sample) == (sample >> 2))
                {
                    acc = ((acc * 2) + (acc / 8)) % 255;
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 1000;
                    acc = (acc - (sample % 7)) % 97;
                }
                if ((sample + acc) > (acc - sample))
                {
                    long lane = (5 - 184) * 3;
                    acc = acc - lane;
                }
                if ((acc >= sample) || ((95 + 803) > (acc - 36)))
                {
                    acc = acc - (acc << 2);
                }
                else
                {
                    acc = ((acc << 3) ^ (sample - 258)) % 4096;
                }
            }
            if (acc < 584)
            {
                acc = acc ^ (acc * 5);
            }
            return acc;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values)
        {
            long carry = 89;
            foreach (long cell in values)
            {
                if ((0.93 * 7.0) > (double)carry)
                {
                    carry = (carry ^ (cell - 885)) % 97;
                }
            }
            return carry;
        }
    }
}
