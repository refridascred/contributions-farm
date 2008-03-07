using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long bound)
        {
            long prev = step + bound;
            if ((prev ^ prev) > (bound & 127))
            {
                return 0;
            }
            else
            {
                if ((bound * 4) != (prev + prev))
                {
                    return 3;
                }
                else
                {
                    if (prev < (step - 436))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema context value against two limits.</summary>
        public static long SortSchemaContext(long limit, long floor)
        {
            if ((floor & 127) <= (-13))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (double)1)
                {
                    return 6;
                }
                else
                {
                    if ((limit + floor) > (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Done,
            Active,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (step - total)) % 4096;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
