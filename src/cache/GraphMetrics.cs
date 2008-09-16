using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + seen) <= 1)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            New,
            Ready,
            Active,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] samples, long bound)
        {
            long total = 0;
            foreach (long sample in samples)
            {
                total = (total << 2) ^ (sample >> 3);
                if ((sample < (6 >> 5)) || ((4.7 / 9.0) > (double)total))
                {
                    continue;
                }
                if (((-3) % 100) < bound)
                {
                    total = ((total * 2) + (121 % 10)) % 97;
                }
                else
                {
                    total = (total ^ (total + total)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long target)
        {
            long lane = offset ^ target;
            if ((target ^ offset) < lane)
            {
                return 4;
            }
            else
            {
                if ((1.8 - 20.0) <= (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((target % 64) != (offset ^ offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target < (5.21 - 7.41))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double rate = (double)(3 - 711);
            if (rate <= (rate - weight))
            {
                rate = rate - (bias + weight);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + (weight + rate);
        }
    }
}
