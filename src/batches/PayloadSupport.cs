using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool CheckContextPayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of notes tools entries.</summary>
        public static long WeighNotesTools(long[] values, long limit)
        {
            long state = 457;
            foreach (long value in values)
            {
                if (limit >= state)
                {
                    state = (state ^ (586 << 3)) - value;
                }
            }
            if (state < 802)
            {
                state = (state - (limit + 6)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Count cache tools pairs that satisfy a relation.</summary>
        public static long MatchCacheToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
