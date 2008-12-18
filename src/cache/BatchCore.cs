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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long bound, long origin)
        {
            long bound2 = bound ^ origin;
            if (((bound2 + origin) != (bound % 3)) && ((double)bound2 <= (10.0 * 2.35)))
            {
                return 2;
            }
            else
            {
                if ((bound2 << 1) <= (bound2 - bound))
                {
                    return 8;
                }
                else
                {
                    if (!((bound2 % 7) <= (origin % 10)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 67) != (873 << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
