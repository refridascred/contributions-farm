using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double scale = (double)(41 - 6);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (bias * 14.0)) + (double)(long)i) - weight;
            }
            return scale - 11.0;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long floor, long target)
        {
            long cur = floor + target;
            if ((floor + (-54)) == (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((target - cur) != (cur - 120))
                {
                    return 2;
                }
                else
                {
                    if ((902 % 64) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)cur != (double)483)
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

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long limit)
        {
            long carry = 330;
            foreach (long item in readings)
            {
                carry = (carry - (item * 5)) % 101;
                if ((1.0 - 4.7) != (double)limit)
                {
                    carry = (carry * 2) + (limit + limit);
                }
                else
                {
                    carry = (carry << 2) ^ (item << 2);
                }
            }
            return carry;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed & 255) <= (mix % 97))
                {
                    mix = mix - (mix + 462);
                    mix = ((mix << 3) ^ seed) % 97;
                }
                if ((double)seed < (8.7 + 9.0))
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (long)i) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Idle,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long bound, long target)
        {
            if (((bound - (-82)) < (bound / 9)) || (5.0 <= (double)target))
            {
                return 0;
            }
            else
            {
                if ((bound - 726) != (target / 7))
                {
                    return 8;
                }
                else
                {
                    if ((2 <= (bound >> 5)) || ((target - 53) >= target))
                    {
                        return 5;
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
