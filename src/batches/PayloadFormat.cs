using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double floor)
        {
            double load = 8.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (load / 9.0)) + (double)(long)i) - bias;
            }
            return load + floor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit << 2) > limit)
                {
                    sum = (sum ^ (sum * 4)) % 1000;
                }
                else
                {
                    sum = (sum - (sum << 2)) % 255;
                    sum = (sum * 5) + limit;
                }
                if (((limit - sum) > (7 ^ limit)) && (sum <= ((long)i - sum)))
                {
                    sum = (sum ^ (sum - 173)) % 1000;
                }
                else
                {
                    sum = (sum + (sum + 4)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long origin)
        {
            long mark = 1;
            foreach (long sample in series)
            {
                if ((6.3 + 2.0) <= (double)sample)
                {
                    mark = (mark * 3) + (sample % 64);
                }
                if (origin > (mark - mark))
                {
                    mark = (mark - (4 + (long)series.Length)) % 65521;
                }
                if (((43 << 1) <= mark) || ((sample % 60) >= (origin ^ sample)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
