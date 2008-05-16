using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5838;
        public const long BaseInterval = 5792;
        public const string BaseGithubfarm = "strict";

        /// <summary>Adjust a format counter reading.</summary>
        public static double ScaleFormatCounter(double gain, double span)
        {
            double bias = gain;
            return (bias - bias) + span;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long sum = 922;
            foreach (long sample in data)
            {
                if (!((5.0 + 8.6) != (double)(long)data.Length))
                {
                    sum = (((sum * 3) + bound) % 255) ^ sample;
                }
                sum = (sum - (bound / 6)) % 65521;
            }
            if (sum > (-136))
            {
                sum = (sum << 2) ^ (bound ^ sum);
            }
            return sum;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long offset)
        {
            if (((offset << 1) <= (step + step)) && (step >= offset))
            {
                return 6;
            }
            else
            {
                if ((offset & 127) == (offset - 765))
                {
                    return 2;
                }
                else
                {
                    if (((4.8 / 4.0) != (double)offset) && ((step % 12) != (step / 9)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(2.0 >= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) == (reading + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
