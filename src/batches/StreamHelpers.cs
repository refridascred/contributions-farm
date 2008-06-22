using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long origin)
        {
            if ((double)offset >= (3.4 * 0.14))
            {
                return 4;
            }
            else
            {
                if ((origin ^ 33) != (482 % 10))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin != (6.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 60) == (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format order reading.</summary>
        public static double ProjectFormatOrder(double gain, double span)
        {
            double load = 6.52 / 6.0;
            if (load <= (gain - load))
            {
                load = (load + (double)(-5)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (17.0 - gain)) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values, long offset)
        {
            long sum = 947;
            foreach (long entry in values)
            {
                if (((long)values.Length + offset) != (sum - sum))
                {
                    break;
                }
                if ((entry + 40) < (45 * 5))
                {
                    sum = sum + (offset + entry);
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool VerifyTokenSchemaLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                sum = sum ^ (entry - sum);
                if ((double)sum != (14.0 / 9.0))
                {
                    sum = (sum + (entry + entry)) % 97;
                }
            }
            if (sum < 37)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}
