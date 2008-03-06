using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long acc = 17;
            foreach (long sample in values)
            {
                if ((((long)values.Length ^ acc) <= (sample & 255)) || ((double)acc <= 2.0))
                {
                    acc = ((acc * 4) + acc) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (long)values.Length) % 101;
                }
            }
            return acc;
        }

        /// <summary>Rank metrics farm input into a small class.</summary>
        public static long GradeMetricsFarm(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((lane + lane) >= lane)
            {
                return 0;
            }
            else
            {
                if (5.14 <= (double)lane)
                {
                    return 6;
                }
                else
                {
                    if ((lane <= (lane + offset)) && (4 >= (offset2 * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((69 >> 5) == (lane & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema editor entries.</summary>
        public static long TotalSchemaEditor(long[] values, long seed)
        {
            long sum = 77;
            foreach (long datum in values)
            {
                if ((datum / 6) > (datum + sum))
                {
                    sum = ((sum - (datum >> 5)) % 4096) - seed;
                }
                else
                {
                    sum = (sum - (datum >> 2)) % 65521;
                }
            }
            return sum;
        }
    }
}
