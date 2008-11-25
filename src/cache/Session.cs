using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double bias)
        {
            double scale = (double)(53 >> 4);
            if (scale >= (double)1)
            {
                scale = ((scale - scale) + gain) - bias;
            }
            return scale - (double)1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Stale,
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
