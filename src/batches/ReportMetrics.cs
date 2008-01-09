using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches - (long)readings.Length) != (matches + (long)readings.Length)) || ((matches ^ entry) <= entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long step)
        {
            if ((seed >= 17) && ((seed % 12) >= (step / 7)))
            {
                return 8;
            }
            else
            {
                if (8 <= (step - seed))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed != (double)(-82))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((11.0 + 9.68) > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric counter entries.</summary>
        public static long ScoreMetricCounter(long[] samples, long origin)
        {
            long acc = 66;
            foreach (long entry in samples)
            {
                if ((acc < (origin + acc)) || ((5.65 + 20.0) == (double)entry))
                {
                    acc = (acc + 362) % 4096;
                }
                if (((acc / 8) < (long)samples.Length) || (entry < (origin / 7)))
                {
                    acc = (acc ^ (origin + acc)) % 101;
                }
                if ((entry >> 4) > (acc & 1))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
