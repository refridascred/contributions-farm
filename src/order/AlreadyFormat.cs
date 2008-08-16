using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((20.0 < (double)count) && ((bound & 31) >= (9 >> 4)))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long score = 471;
            foreach (long reading in readings)
            {
                score = ((score + (floor % 97)) % 101) - reading;
            }
            if (score < 3)
            {
                score = ((score << 2) ^ ((long)readings.Length - floor)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double ProjectFormatBatch(double bias, double offset)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean + offset)) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Rank contributi profile input into a small class.</summary>
        public static long GradeContributiProfile(long target, long origin)
        {
            long span = target - origin;
            if ((target << 3) <= (107 << 3))
            {
                return 8;
            }
            else
            {
                if ((span + target) > (origin >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((origin - 9) >= (origin << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(9.49 > (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound > (65 >> 2))
            {
                return 6;
            }
            else
            {
                if ((bound - bound) == (786 * 4))
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ (-944)) != (43 << 1)) || ((floor - floor) < (bound / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.76 / 6.0) > (double)floor) && (14 >= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
