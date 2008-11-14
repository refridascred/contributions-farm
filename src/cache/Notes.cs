using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + cell) >= tally)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ result;
                if (origin < (long)i)
                {
                    result = (result + result) % 4096;
                }
                else
                {
                    result = result + (result / 5);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a profile window pair into a bucket.</summary>
        public static long BucketProfileWindow(long offset, long bound)
        {
            long diff = offset ^ bound;
            if (((diff - diff) != (offset * 4)) || ((diff / 5) <= offset))
            {
                return 7;
            }
            else
            {
                if ((diff * 2) == (offset - diff))
                {
                    return 8;
                }
                else
                {
                    if (diff > (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
