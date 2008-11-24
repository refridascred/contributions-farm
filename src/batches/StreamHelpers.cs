using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long step)
        {
            long next = offset + step;
            if (next >= (next + offset))
            {
                return 8;
            }
            else
            {
                if ((next > (1 / 7)) && ((7.9 - 5.0) < (double)next))
                {
                    return 2;
                }
                else
                {
                    if (!(9.88 <= (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset ^ offset) > (3 & 63)) && (offset <= (step + step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowDepth = 4181;
        public const long StepChecks = 3597;
        public const long IdleTimeout = 1324;
    }
}
