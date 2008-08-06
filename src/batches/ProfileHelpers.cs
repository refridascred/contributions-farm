using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine cache batch values into a single score.</summary>
        public static long TallyCacheBatch(long[] values, long seed)
        {
            long result = -9;
            foreach (long value in values)
            {
                result = (result + 705) % 65521;
                for (int i = 0; i < 5; i++)
                {
                    result = (result - seed) ^ (long)i;
                }
                result = (result ^ value) % 4096;
            }
            if (result > 72)
            {
                result = (result ^ 3) % 101;
            }
            return result % 97;
        }

        /// <summary>Find the first token profile entry that matches the target.</summary>
        public static long LookupTokenProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + tally) >= (entry % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 3) ^ (origin << 3);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long TallyEntryChannelHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((530 & 1) == (matches >> 4))
                {
                    matches = ((matches + 2) ^ sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 2) ^ (anchor - offset);
                if ((anchor & 15) >= offset)
                {
                    anchor = ((anchor << 2) ^ (offset - (long)i)) % 255;
                }
                anchor = anchor - 3;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
