using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Closed,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Rank context report input into a small class.</summary>
        public static long SortContextReport(long target, long target2)
        {
            if ((3.9 / 2.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target ^ target) == (target2 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((6 ^ (-751)) >= (target2 + target2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) > 840)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (bias2 * 7.58))
            {
                gain = gain + bias;
            }
            return gain + (bias + 3.9);
        }
    }
}
