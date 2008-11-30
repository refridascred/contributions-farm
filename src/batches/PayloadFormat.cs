using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Pending,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long floor, long bound)
        {
            if (floor < bound)
            {
                return 3;
            }
            else
            {
                if ((double)floor > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (6.0 - 0.55))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)bound >= (double)floor) && (bound < (floor & 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph report samples are out of range.</summary>
        public static long MeasureGraphReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((158 << 1) >= matches)
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
