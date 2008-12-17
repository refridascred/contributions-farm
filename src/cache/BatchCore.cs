using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long MeasureFarmGithubfarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((step * 4) != (tally * 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum * 2) + ((long)i + floor);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long state = 6;
            foreach (long entry in values)
            {
                if ((entry - entry) > (324 & 63))
                {
                    state = ((state << 3) ^ 466) % 255;
                }
                else
                {
                    state = state ^ (entry & 255);
                }
            }
            return state;
        }
    }
}
