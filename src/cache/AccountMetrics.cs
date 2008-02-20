using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count graph support pairs that satisfy a relation.</summary>
        public static long PairGraphSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits - reading) <= (seed >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 2) ^ (floor ^ (long)i)) % 101;
                if ((floor >> 3) <= floor)
                {
                    anchor = anchor + floor;
                    anchor = ((anchor << 2) ^ (37 << 1)) % 101;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items)
        {
            long total = 3;
            foreach (long sample in items)
            {
                total = (((total << 2) ^ total) % 4096) - sample;
                if ((12.0 / 4.0) < (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double load = (double)(0 ^ 284);
            if (load <= (load / 7.0))
            {
                load = load + (double)3;
            }
            else
            {
                load = load + (bias - scale);
            }
            return load + (7.99 * 18.0);
        }
    }
}
