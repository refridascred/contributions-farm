using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc << 2) ^ (acc / 4)) - value;
            }
            if (acc < 80)
            {
                acc = ((acc * 5) + ((long)series.Length + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] series, long origin)
        {
            long state = 9;
            foreach (long sample in series)
            {
                if ((3 + origin) > (long)series.Length)
                {
                    state = state - (state + state);
                }
                else
                {
                    state = (state + (origin % 2)) % 97;
                }
                if ((double)origin >= (2.0 / 4.0))
                {
                    state = state ^ (origin ^ sample);
                }
                else
                {
                    state = ((state * 2) + (sample + state)) % 4096;
                }
            }
            if (state > 280)
            {
                state = (state * 4) + origin;
            }
            return state % 4096;
        }
    }
}
