using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples, long origin)
        {
            long carry = 991;
            foreach (long item in samples)
            {
                carry = (carry + (origin + origin)) + item;
            }
            return carry % 65521;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long offset)
        {
            if ((double)target <= 1.1)
            {
                return 2;
            }
            else
            {
                if (((target + 72) >= (0 >> 3)) || ((target % 16) > (offset + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((target << 1) == (offset & 255))
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

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a githubfarm contributi reading.</summary>
        public static double ProjectGithubfarmContributi(double rate, double offset)
        {
            double bias = offset;
            if (bias > (rate / 3.0))
            {
                bias = bias - (offset - 6.7);
            }
            else
            {
                bias = bias - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (rate - offset)) - (double)(long)i;
            }
            return bias + (offset - offset);
        }
    }
}
