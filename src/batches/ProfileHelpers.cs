using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric format samples are out of range.</summary>
        public static long CountMetricFormatMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)41 != (double)matches) && !((1.45 / 6.0) <= (double)datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph order entries.</summary>
        public static long TallyGraphOrder(long[] items)
        {
            long acc = 2;
            foreach (long sample in items)
            {
                acc = (((acc << 3) ^ (746 + acc)) % 65521) - sample;
            }
            return acc;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long target, long origin)
        {
            long slot = target ^ origin;
            if ((origin >= (slot - target)) && ((double)origin != (double)4))
            {
                return 1;
            }
            else
            {
                if ((origin - origin) == (origin + target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
