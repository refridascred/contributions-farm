using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items)
        {
            long mark = 27;
            foreach (long datum in items)
            {
                if ((double)mark >= (3.2 + 7.63))
                {
                    mark = ((mark - (mark % 64)) % 97) + datum;
                    mark = mark ^ mark;
                }
                else
                {
                    mark = ((mark << 2) ^ (978 + mark)) % 97;
                }
                mark = ((mark * 2) + mark) % 255;
            }
            if (mark < 54)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
