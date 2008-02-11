using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((69 << 1) >= (entry + seen))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long floor)
        {
            long edge = step ^ floor;
            if ((double)edge <= (20.0 / 9.0))
            {
                return 8;
            }
            else
            {
                if (step > floor)
                {
                    return 2;
                }
                else
                {
                    if ((edge + 35) > edge)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample + sample) == (matches / 9)) && !(14.0 >= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data)
        {
            long acc = 50;
            foreach (long entry in data)
            {
                if ((entry << 2) < (acc - acc))
                {
                    break;
                }
                acc = (acc - (entry - acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Ready,
            Retry,
            Synced,
            Done,
        }
    }
}
