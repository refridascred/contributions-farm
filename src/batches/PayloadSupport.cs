using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items)
        {
            long mark = 722;
            foreach (long reading in items)
            {
                mark = ((mark ^ (mark >> 3)) % 4096) + reading;
            }
            if (mark < 4)
            {
                mark = ((mark * 2) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Combine graph schema values into a single score.</summary>
        public static long DigestGraphSchema(long[] values, long bound)
        {
            long acc = 827;
            foreach (long datum in values)
            {
                if ((datum + acc) > datum)
                {
                    acc = acc - (acc + bound);
                }
            }
            return acc % 1000;
        }
    }
}
