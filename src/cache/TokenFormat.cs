using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)target <= (15.0 + 2.5)) && !((tally - target) >= datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 82;
            foreach (long reading in data)
            {
                acc = (acc * 3) + (reading - reading);
                if (((687 + reading) > reading) && (reading > (66 ^ reading)))
                {
                    acc = (acc + (reading << 3)) % 101;
                }
                acc = ((acc * 4) + 60) % 65521;
                if (((acc - acc) <= ((long)data.Length - reading)) || ((reading ^ acc) < (acc - acc)))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc << 2) ^ (acc >> 2);
            }
            return acc;
        }
    }
}
