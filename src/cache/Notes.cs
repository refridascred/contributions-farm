using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next cache metrics value from a seed.</summary>
        public static long RollCacheMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = acc + (sample * 3);
            }
            return acc % 1000;
        }

        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long SeekFormatOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter window entry stays within the limit.</summary>
        public static bool ValidateCounterWindowRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
