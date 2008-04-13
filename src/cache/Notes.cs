using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double floor)
        {
            double weight = (double)(0 + 851);
            if (weight >= floor)
            {
                weight = (weight + floor) + rate;
            }
            return weight - floor;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double ratio = 1.78;
            if (ratio <= ratio)
            {
                ratio = ((ratio + (ratio + 16.0)) + scale) - floor;
            }
            else
            {
                ratio = ratio + (double)85;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - (double)8;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long seed)
        {
            if (((double)floor == (4.0 - 5.89)) && (floor <= (floor + seed)))
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (6.4 - 15.0))
                {
                    return 6;
                }
                else
                {
                    if (!((double)seed > (double)8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Synced,
            Active,
            New,
            Dropped,
        }
    }
}
