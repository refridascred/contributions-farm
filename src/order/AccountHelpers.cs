using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (8 >> 4)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - 2) > (5 ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry >= (origin / 6)) && ((double)count > (4.4 - 6.84)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long RollGraphFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ result) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
