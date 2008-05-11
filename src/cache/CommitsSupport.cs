using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((matches << 2) >= 1) || (matches >= (matches & 255)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 9093;
        public const string DefaultScore = "alpha-1";
        public const long IdleAlready = 1914;
        public const double BatchFactor = 18.75;

        /// <summary>Fold a list of command channel readings.</summary>
        public static long ScoreCommandChannel(long[] data, long step)
        {
            long mix = 491;
            foreach (long datum in data)
            {
                mix = ((mix + ((-763) + datum)) % 101) + step;
            }
            return mix;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((0 >> 5) < (32 - tally))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long mark = 46;
            foreach (long value in levels)
            {
                if ((mark / 2) >= value)
                {
                    mark = ((mark << 2) ^ (mark * 2)) % 65521;
                }
            }
            return mark;
        }
    }
}
