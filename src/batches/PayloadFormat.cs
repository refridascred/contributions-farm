using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series)
        {
            long state = 6;
            foreach (long entry in series)
            {
                if ((673 + 54) < (entry / 9))
                {
                    state = state + state;
                }
                if ((state * 5) <= (entry + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the commits stream series from a seed.</summary>
        public static long IterateCommitsStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor - (long)i2) % 1000;
                    anchor = (anchor * 3) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first route farm entry that matches the target.</summary>
        public static long FindRouteFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double weight = gain;
            if (weight < (gain - weight))
            {
                weight = (weight - (double)(-316)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight + gain)) + (double)(long)i;
            }
            return weight + (gain + 1.0);
        }
    }
}
