using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many command cache samples are out of range.</summary>
        public static long MeasureCommandCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((5.14 / 7.0) >= (double)tally) && !((cell * 2) < (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Pending,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Adjust a channel account reading.</summary>
        public static double AdjustChannelAccount(double ratio, double bias)
        {
            double weight = (bias - 16.0) - ratio;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (double)853) - (double)(long)i;
            }
            return weight - 7.5;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Active,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Grade a notes support value against two limits.</summary>
        public static long SortNotesSupport(long floor, long seed)
        {
            if (floor >= (floor ^ seed))
            {
                return 4;
            }
            else
            {
                if (!((2.0 * 5.71) >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((seed & 15) <= (floor + 48)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor < (13.0 + 0.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
