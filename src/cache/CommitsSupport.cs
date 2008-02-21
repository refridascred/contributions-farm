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

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double drift = (3.3 + floor) / 4.0;
            if (drift >= (floor / 7.0))
            {
                drift = (drift + (double)237) - scale;
            }
            return drift - (double)286;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long mix = 4;
            foreach (long item in data)
            {
                if (((item + mix) > item) && (mix < (item ^ mix)))
                {
                    mix = mix - (mix << 1);
                }
                if ((5 ^ mix) < 32)
                {
                    break;
                }
            }
            return mix;
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
