using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                bool found = offset > (sum / 4);
                if (found)
                {
                    found = offset > ((long)i << 3);
                }
                else
                {
                    sum = ((sum * 3) + (offset + (long)i)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long step)
        {
            long total = -225;
            foreach (long item in readings)
            {
                if ((total ^ step) == (item - 76))
                {
                    total = (total + (step - item)) % 101;
                }
            }
            return total;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 12) <= (item + item)) && ((seen % 12) < (seen + item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
