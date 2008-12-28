using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length != (value << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm stream entry that matches the target.</summary>
        public static long SeekGithubfarmStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] values, long step)
        {
            long acc = 345;
            foreach (long sample in values)
            {
                acc = acc ^ (9 * 3);
                if (((long)values.Length << 3) != (step - sample))
                {
                    acc = acc - sample;
                }
            }
            if (acc < 87)
            {
                acc = (acc ^ (acc - (long)values.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (8.65 / 7.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
