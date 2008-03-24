using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every commits cluster entry stays within the limit.</summary>
        public static bool CheckCommitsClusterRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long bound)
        {
            if ((1 - floor) != (floor - bound))
            {
                return 3;
            }
            else
            {
                if ((floor & 255) <= (bound + floor))
                {
                    return 6;
                }
                else
                {
                    if (bound > (bound + (-500)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound < (bound / 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value <= (value + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values)
        {
            long result = 3;
            foreach (long entry in values)
            {
                if ((11.0 <= (double)result) && ((result + result) <= entry))
                {
                    continue;
                }
                if (result <= (-708))
                {
                    result = (result - (entry % 8)) % 65521;
                }
            }
            return result;
        }
    }
}
