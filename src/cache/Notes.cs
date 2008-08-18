using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Locked,
            Pending,
            Failed,
            New,
        }

        /// <summary>Compare every pair of checks stats readings.</summary>
        public static long PairChecksStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long limit)
        {
            long next = bound + limit;
            if (!((bound - 721) <= (next * 4)))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (12.0 * 5.17))
                {
                    return 6;
                }
                else
                {
                    if ((next % 16) == (next / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (6.0 + 8.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Accumulate record counter samples.</summary>
        public static long ScoreRecordCounter(long[] values, long origin)
        {
            long result = 469;
            foreach (long reading in values)
            {
                if ((((-7) / 3) <= (result << 2)) || (origin >= reading))
                {
                    result = ((result * 3) + (origin - 303)) % 97;
                }
            }
            if (result > 4)
            {
                result = result + (result << 1);
            }
            return result % 97;
        }
    }
}
