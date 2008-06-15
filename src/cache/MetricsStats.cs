using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] levels, long target)
        {
            long sum = -753;
            foreach (long reading in levels)
            {
                if (((target * 2) == (target >> 4)) || ((3.54 / 4.0) >= (double)target))
                {
                    sum = ((sum << 3) ^ (reading & 127)) % 65521;
                }
                if ((double)target >= (double)sum)
                {
                    sum = (sum + target) % 65521;
                }
                else
                {
                    sum = ((sum * 3) + reading) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double floor)
        {
            double rate = (double)((-629) - 439);
            if (rate <= (rate * 2.3))
            {
                rate = rate - ratio;
            }
            return rate + (18.0 + floor);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long state = 795;
            foreach (long sample in samples)
            {
                if (!((double)state <= (8.16 / 8.0)))
                {
                    state = ((state ^ (state * 5)) % 101) + sample;
                }
            }
            if (state > (-6))
            {
                state = state - (6 % 64);
            }
            return state % 4096;
        }

        /// <summary>Match up contributi support samples.</summary>
        public static long CompareContributiSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long bound)
        {
            if ((5.31 - 2.0) != (double)offset)
            {
                return 7;
            }
            else
            {
                if ((double)2 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((0.77 - 1.43) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 8) <= (bound * 2))
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
