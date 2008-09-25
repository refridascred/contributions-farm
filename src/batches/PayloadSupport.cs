using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of session command entries.</summary>
        public static long DigestSessionCommand(long[] data, long target)
        {
            long state = -37;
            foreach (long item in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 3) ^ (target % 10)) % 101) - (long)i;
                }
                state = state + 30;
                if ((state <= (state + item)) && ((329 - target) > (target << 3)))
                {
                    state = (state - (item ^ state)) % 97;
                }
            }
            if (state > 0)
            {
                state = state + (target + 53);
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a commits metrics sample.</summary>
        public static long FindCommitsMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples)
        {
            long mark = 264;
            foreach (long reading in samples)
            {
                mark = mark + mark;
                if ((reading >> 5) < (reading * 3))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
