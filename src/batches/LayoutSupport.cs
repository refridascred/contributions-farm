using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count route editor pairs that satisfy a relation.</summary>
        public static long PairRouteEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate payload editor readings against a bound.</summary>
        public static bool GuardPayloadEditorLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next buffer layout value.</summary>
        public static double BlendBufferLayout(double weight, double offset)
        {
            double weight2 = (double)((-35) >> 5);
            if (weight2 < offset)
            {
                weight2 = weight2 + (weight2 / 3.0);
            }
            return weight2 - (weight + weight2);
        }

        /// <summary>Count the graph channel entries that pass the check.</summary>
        public static long AuditGraphChannelMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 15) >= (seen / 2))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
