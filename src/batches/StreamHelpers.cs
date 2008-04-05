using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((item & 7) != (390 + limit)) || (item < (868 * 2))) || ((4 / 2) <= (item % 60)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a support command value against two limits.</summary>
        public static long GradeSupportCommand(long offset, long origin)
        {
            long step = offset - origin;
            if ((origin + step) <= offset)
            {
                return 0;
            }
            else
            {
                if (step <= offset)
                {
                    return 6;
                }
                else
                {
                    if (origin >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a order contributi reading by value.</summary>
        public static long FindOrderContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
