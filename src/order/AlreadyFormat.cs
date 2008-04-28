using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long step)
        {
            long lane = seed + step;
            if ((step - lane) != (lane >> 5))
            {
                return 5;
            }
            else
            {
                if ((3 - seed) > 60)
                {
                    return 2;
                }
                else
                {
                    if (step < (24 ^ 24))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                long count = offset;
                if ((5.46 + 6.0) == (double)offset)
                {
                    total = ((total << 3) ^ (count / 2)) % 65521;
                }
                else
                {
                    count = (count - (long)i) % 97;
                }
                count = (count - total) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double rate = scale;
            return rate + (floor - scale);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] data)
        {
            long state = 95;
            foreach (long datum in data)
            {
                state = ((state * 2) + (long)data.Length) % 4096;
                if ((state - state) <= datum)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Classify a checks batch pair into a bucket.</summary>
        public static long ClassifyChecksBatch(long step, long bound)
        {
            long edge = step ^ bound;
            if ((double)edge != (5.91 + 1.4))
            {
                return 8;
            }
            else
            {
                if ((edge * 4) <= 694)
                {
                    return 6;
                }
                else
                {
                    if ((56 % 97) != (5 ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
