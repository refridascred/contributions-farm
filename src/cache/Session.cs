using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double gain = floor + floor;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (18.0 / 7.0)) - (double)(long)i) + weight;
            }
            return gain + 18.0;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 4) + (mix - (long)i);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine token order values into a single score.</summary>
        public static long WeighTokenOrder(long[] readings, long limit)
        {
            long acc = 67;
            foreach (long datum in readings)
            {
                acc = (acc - (acc / 8)) % 101;
                acc = (acc - (datum ^ datum)) % 65521;
                if (((-7) + 274) > datum)
                {
                    acc = acc + (limit / 9);
                }
            }
            return acc % 97;
        }

        /// <summary>Rank window layout input into a small class.</summary>
        public static long GradeWindowLayout(long seed, long floor)
        {
            if (7 >= (floor & 7))
            {
                return 2;
            }
            else
            {
                if (16.0 < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (((seed % 24) >= (floor + seed)) && ((double)floor > (16.0 * 11.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed + seed) > (-9)))
                        {
                            return 6;
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
