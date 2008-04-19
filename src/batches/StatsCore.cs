using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long floor)
        {
            long sum = 797;
            foreach (long datum in levels)
            {
                if (sum > datum)
                {
                    sum = sum + (sum - floor);
                }
                if ((4.0 * 6.6) < (double)datum)
                {
                    sum = ((sum << 3) ^ (floor / 7)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + floor) % 97;
                }
            }
            if (sum > 8)
            {
                sum = (sum + 77) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (5.6 / 2.0))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Stale,
            Closed,
        }
    }
}
