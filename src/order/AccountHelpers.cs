using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long origin)
        {
            long state = -683;
            foreach (long reading in levels)
            {
                if (reading > (444 >> 4))
                {
                    state = (state ^ (origin / 5)) % 1000;
                }
            }
            if (state > (-515))
            {
                state = state - (-8);
            }
            return state;
        }

        /// <summary>Measure how many editor layout samples are out of range.</summary>
        public static long AuditEditorLayoutMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(entry < (origin % 64)) && ((double)entry <= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long offset)
        {
            long slot = floor - offset;
            if ((9 & 3) > offset)
            {
                return 8;
            }
            else
            {
                if (floor > (slot >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)slot <= (0.82 * 9.62))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every report contributi entry stays within the limit.</summary>
        public static bool VerifyReportContributiRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
