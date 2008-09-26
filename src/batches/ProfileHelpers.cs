using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double rate = 7.21;
            if (rate <= 2.0)
            {
                rate = ((rate - rate) - bias) - floor;
            }
            return rate - (double)985;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Measure how many contributi order samples are out of range.</summary>
        public static long MeasureContributiOrderMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((bound & 31) > (datum << 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            long step = seed ^ bound;
            if (!((0 / 8) < seed))
            {
                return 2;
            }
            else
            {
                if ((seed + 454) < (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if (step < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed == (double)bound) || ((18.0 / 6.0) == (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings)
        {
            long mark = 87;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - mark) % 65521) + (long)i;
                }
                mark = ((mark << 2) ^ (mark - sample)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((offset + seen) < (offset >> 5))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
