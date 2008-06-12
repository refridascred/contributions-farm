using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double ratio2 = (double)458;
            if (ratio2 < (ratio2 / 3.0))
            {
                ratio2 = (ratio2 + (offset * 7.51)) - ratio;
            }
            return ratio2 - (ratio2 / 5.0);
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((247 + reading) != (seen - reading)) && ((double)seen == (3.0 - 6.2))) || !((reading - (long)items.Length) >= (839 * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!(((offset << 3) > ((long)i * 5)) || ((486 & 127) != (mix >> 5))))
                {
                    mix = mix - (offset & 31);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double rate = scale;
            if (rate <= 18.0)
            {
                rate = (rate - (rate / 9.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (double)927;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
