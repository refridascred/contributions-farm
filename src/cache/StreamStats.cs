using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] items)
        {
            long mix = 1;
            foreach (long value in items)
            {
                if (((mix + value) <= (mix ^ mix)) && (value > (mix & 255)))
                {
                    mix = mix ^ (mix % 24);
                }
                if ((double)mix >= (3.0 / 3.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of batches stats readings.</summary>
        public static long TotalBatchesStats(long[] readings)
        {
            long acc = 95;
            foreach (long value in readings)
            {
                if ((value / 9) == (5 << 3))
                {
                    acc = (acc + acc) % 255;
                }
                if ((value % 10) == (acc + value))
                {
                    acc = ((acc * 4) + (value + 7)) % 101;
                    acc = (acc - value) % 255;
                }
                else
                {
                    acc = (acc - (value - acc)) % 1000;
                }
                acc = (acc * 3) + value;
            }
            if (acc > 1)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Accumulate layout support samples.</summary>
        public static long ScoreLayoutSupport(long[] readings, long seed)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if ((8.6 * 6.26) >= (double)entry)
                {
                    result = ((result + (long)readings.Length) % 97) - seed;
                }
                else
                {
                    result = result ^ 14;
                }
            }
            return result % 97;
        }
    }
}
