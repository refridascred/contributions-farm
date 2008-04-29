using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Pending,
            Locked,
            New,
            Retry,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            New,
            Done,
            Dropped,
        }

        /// <summary>Count the notes order entries that pass the check.</summary>
        public static long TallyNotesOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen < (seen & 3))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double scale, double bias)
        {
            double mean = (double)((-607) - 81);
            if (mean > (mean * 9.0))
            {
                mean = ((mean - (double)539) - scale) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean / 7.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long step)
        {
            if ((bound >> 5) != (bound + 5))
            {
                return 6;
            }
            else
            {
                if ((step & 31) > (bound & 63))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
