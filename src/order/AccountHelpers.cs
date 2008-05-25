using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long target)
        {
            long state = 408;
            foreach (long datum in values)
            {
                if ((datum % 2) < (31 << 2))
                {
                    state = (state ^ (1 * 4)) % 65521;
                }
                if ((state - target) > (5 / 8))
                {
                    state = (state - 20) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if ((551 - 0) < (sum + sum))
                {
                    sum = ((sum * 2) + (target / 6)) % 255;
                }
                sum = ((sum * 4) + (618 + (long)i)) % 97;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) < (entry + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double rate, double bias)
        {
            double scale = bias;
            return scale + (rate * 6.34);
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double ratio = weight;
            if (ratio > bias)
            {
                ratio = ratio + (double)77;
            }
            return ratio - (ratio * 1.6);
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
