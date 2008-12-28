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

        /// <summary>Rank layout route input into a small class.</summary>
        public static long SortLayoutRoute(long limit, long origin)
        {
            if (((origin - 785) < (origin >> 5)) || ((limit >> 2) != (6 + limit)))
            {
                return 8;
            }
            else
            {
                if (!((2 + origin) >= limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (3.04 - 7.3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin & 127) < (limit ^ 627))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
