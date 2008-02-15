using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long total = 16;
            foreach (long reading in series)
            {
                if (!((total - total) > (total << 1)))
                {
                    total = ((total << 2) ^ reading) % 1000;
                }
                if (!((total % 12) != (21 ^ reading)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long bound)
        {
            if ((step + 655) <= step)
            {
                return 1;
            }
            else
            {
                if (!((step - bound) > (step + bound)))
                {
                    return 8;
                }
                else
                {
                    if ((step << 2) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + 67) <= (45 / 6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double mean = 3.32;
            if (mean <= (9.8 - mean))
            {
                mean = mean - (double)52;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + floor;
        }
    }
}
