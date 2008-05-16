using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i > step)
                {
                    anchor = (anchor << 3) ^ (step - step);
                }
                if ((step * 2) < anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - (anchor + 69)) % 255;
                }
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long mix = 0;
            foreach (long entry in samples)
            {
                if (((double)mix > (3.0 / 5.0)) && ((mix - entry) >= (entry * 2)))
                {
                    continue;
                }
                mix = (mix * 2) + (0 ^ entry);
            }
            if (mix > 4)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((7.2 <= (double)reading) || ((double)origin == (double)307))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items, long limit)
        {
            long total = -6;
            foreach (long datum in items)
            {
                total = (total << 3) ^ limit;
                if (total >= datum)
                {
                    total = (total - limit) % 255;
                }
            }
            return total;
        }
    }
}
