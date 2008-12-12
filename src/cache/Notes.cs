using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double floor)
        {
            double ratio = scale + (floor / 9.0);
            return ratio - (scale + 5.5);
        }

        /// <summary>Derive the next counter route value from a seed.</summary>
        public static long DeriveCounterRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score ^ (score / 2)) + (long)i2;
                    score = (score * 5) + (score * 4);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every tools graph entry stays within the limit.</summary>
        public static bool VerifyToolsGraphBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
