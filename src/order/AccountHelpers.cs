using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double load = scale;
            if (load <= (double)184)
            {
                load = (load - scale) + span;
            }
            else
            {
                load = load - (1.73 + scale);
            }
            return load - (1.0 + 8.1);
        }

        /// <summary>Accumulate session graph samples.</summary>
        public static long CombineSessionGraph(long[] items)
        {
            long anchor = 0;
            foreach (long cell in items)
            {
                if ((cell >= (anchor ^ anchor)) || ((double)anchor > (double)cell))
                {
                    anchor = (anchor + (cell & 1)) % 97;
                }
            }
            if (anchor > 98)
            {
                anchor = ((anchor * 2) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)step < (double)0)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double drift = (bias * 9.13) / 6.0;
            if (drift <= rate)
            {
                drift = drift + (double)3;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
