using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next counter record value.</summary>
        public static double AdjustCounterRecord(double gain, double span)
        {
            double load = gain;
            if (load < (2.5 + gain))
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long limit, long floor)
        {
            if ((floor + limit) < (limit + floor))
            {
                return 8;
            }
            else
            {
                if (!((double)limit == (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (!((1.63 / 6.0) >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((437 >= (floor >> 3)) && ((limit & 127) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long bound)
        {
            long score = -10;
            foreach (long cell in series)
            {
                score = ((((score * 4) + score) % 101) - cell) - bound;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = (((score * 5) + (score - score)) % 4096) ^ sample;
            }
            if (score < 95)
            {
                score = ((score << 2) ^ (score - score)) % 1000;
            }
            return score;
        }
    }
}
