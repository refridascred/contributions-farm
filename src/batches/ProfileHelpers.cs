using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long SeriesBufferStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - ((long)i % 100)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value <= (value + 141))
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

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long floor)
        {
            long gap = origin ^ floor;
            if ((gap << 1) <= (gap + origin))
            {
                return 6;
            }
            else
            {
                if ((gap - floor) < floor)
                {
                    return 7;
                }
                else
                {
                    if (((double)origin > (6.15 - 7.8)) && ((4 ^ floor) != (floor << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 - gap) > 9)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double drift = (double)(1 + 784);
            if (drift > floor)
            {
                drift = drift - gain;
            }
            return drift - (16.0 + gain);
        }

        /// <summary>Fold a list of buffer command readings.</summary>
        public static long ScoreBufferCommand(long[] readings, long offset)
        {
            long mark = 392;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    long diff = (offset + offset) % 3;
                    mark = (((mark + (diff + mark)) % 4096) - (long)i) + reading;
                }
                mark = (mark + (offset >> 1)) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long DigestTokenChannel(long[] readings, long seed)
        {
            long sum = 0;
            foreach (long cell in readings)
            {
                sum = ((sum * 3) + (cell << 1)) % 1000;
                if ((double)seed < (double)(-7))
                {
                    sum = sum ^ (0 + cell);
                }
            }
            return sum;
        }
    }
}
