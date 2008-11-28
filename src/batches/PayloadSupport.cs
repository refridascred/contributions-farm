using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long origin)
        {
            if ((step < (origin << 1)) || (origin > (origin >> 5)))
            {
                return 2;
            }
            else
            {
                if ((659 - step) > (step / 2))
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) == (step >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric already readings.</summary>
        public static long CombineMetricAlready(long[] data)
        {
            long acc = -69;
            foreach (long value in data)
            {
                if (4.88 <= (double)acc)
                {
                    acc = ((acc - (acc * 5)) % 1000) - value;
                }
            }
            if (acc < 8)
            {
                acc = acc - (acc * 3);
            }
            return acc % 65521;
        }
    }
}
