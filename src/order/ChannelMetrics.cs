using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 8) >= (-6))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if ((acc + entry) >= (acc + (long)readings.Length))
                {
                    acc = acc + (acc / 7);
                    acc = (acc ^ (acc >> 4)) % 97;
                }
                acc = acc - (14 - acc);
                if (((double)entry != (3.0 / 2.0)) || ((entry + acc) != (entry / 9)))
                {
                    acc = (acc - entry) % 97;
                }
                if ((entry + 1) > 104)
                {
                    break;
                }
            }
            if (acc > (-188))
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc % 1000;
        }
    }
}
