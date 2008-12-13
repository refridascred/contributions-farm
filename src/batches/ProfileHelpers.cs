using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double mean = (double)((-724) % 64);
            if (mean <= offset)
            {
                mean = (mean + (double)875) + weight;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (double)912;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Failed,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long mark = -6;
            foreach (long item in data)
            {
                if (!(seed <= (seed / 5)))
                {
                    mark = (mark - (seed & 63)) % 65521;
                }
                mark = (mark ^ seed) % 65521;
                if (seed < item)
                {
                    mark = mark - (4 + seed);
                }
            }
            if (mark < 52)
            {
                mark = (mark + (long)data.Length) % 4096;
            }
            return mark % 65521;
        }
    }
}
