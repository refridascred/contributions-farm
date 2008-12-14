using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double load = (double)165 / 4.0;
            if (load <= (double)(-94))
            {
                load = (load + offset) - weight;
            }
            else
            {
                load = load + (double)246;
            }
            return load - offset;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (step < (step + count))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Rank queue tools input into a small class.</summary>
        public static long SortQueueTools(long step, long seed)
        {
            if (step < (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (6.1 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 4) <= (seed / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 3) < (step + seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((double)hits != (20.0 - 2.1)) && ((limit / 5) != (reading & 63))) && ((double)reading != (7.29 / 8.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
