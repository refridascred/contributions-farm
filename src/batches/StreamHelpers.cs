using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a commits layout pair into a bucket.</summary>
        public static long GradeCommitsLayout(long target, long origin)
        {
            long diff = target - origin;
            if ((origin + origin) == (731 & 3))
            {
                return 3;
            }
            else
            {
                if ((diff > (592 / 2)) && ((double)origin <= 1.7))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >= (cell & 127)) && ((tally >> 2) <= (cell / 9)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - value) > ((long)samples.Length ^ 9))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long acc = 5;
            foreach (long value in levels)
            {
                acc = (((acc * 4) + (acc + acc)) % 65521) ^ value;
            }
            return acc % 1000;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Idle,
            Failed,
            Paused,
        }
    }
}
