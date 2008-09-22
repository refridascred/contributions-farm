using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long score = 687;
            foreach (long cell in series)
            {
                if ((cell >> 3) > (score << 3))
                {
                    score = (score - (score & 1)) % 65521;
                }
                if (((double)cell == (19.0 / 8.0)) && (6.5 > (double)score))
                {
                    break;
                }
            }
            if (score < (-3))
            {
                score = (score * 3) + (score ^ 308);
            }
            return score;
        }

        /// <summary>Audit entry command readings against a rule.</summary>
        public static long MeasureEntryCommandHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value >> 1) >= step)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch route pair into a bucket.</summary>
        public static long SortBatchRoute(long step, long origin)
        {
            if ((double)origin > (7.26 - 8.2))
            {
                return 5;
            }
            else
            {
                if ((step + origin) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 63) >= (origin << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Draft,
            Stale,
            New,
            Done,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long acc = 71;
            foreach (long datum in items)
            {
                acc = (acc ^ (datum * 5)) % 97;
            }
            return acc;
        }
    }
}
