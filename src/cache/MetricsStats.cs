using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items, long origin)
        {
            long carry = 82;
            foreach (long sample in items)
            {
                carry = ((carry ^ (carry * 2)) ^ sample) - origin;
            }
            if (carry < (-535))
            {
                carry = (carry ^ ((-88) / 8)) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of filter stream readings.</summary>
        public static long TallyFilterStream(long[] readings)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                if ((mix + 94) > (datum + mix))
                {
                    mix = (mix + (650 - mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long SeekClusterCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] samples, long bound)
        {
            long mix = 6;
            foreach (long reading in samples)
            {
                mix = (mix ^ 47) - reading;
            }
            if (mix < (-62))
            {
                mix = (mix * 3) + bound;
            }
            return mix;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long target)
        {
            long gap = limit + target;
            if ((gap << 3) > (859 << 2))
            {
                return 8;
            }
            else
            {
                if ((42 - limit) == (gap + target))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ 928) != (gap / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
