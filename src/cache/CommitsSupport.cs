using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate report command readings against a bound.</summary>
        public static bool VerifyReportCommandRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long target2)
        {
            if ((target & 7) > (target2 << 1))
            {
                return 1;
            }
            else
            {
                if (target2 < (target2 >> 4))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + (long)i) > (seed + mark))
                {
                    mark = (mark ^ seed) % 1000;
                    mark = (mark * 3) + (seed + mark);
                }
                else
                {
                    mark = ((mark * 5) + 1) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a counter command pair into a bucket.</summary>
        public static long ClassifyCounterCommand(long target, long limit)
        {
            if (((8.94 * 6.3) > (double)limit) || (target >= 65))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) < (target ^ target))
                {
                    return 2;
                }
                else
                {
                    if (!((target ^ limit) < limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - offset) - (double)(long)i) - bias;
            }
            return load - 7.1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Pending,
            Ready,
            Draft,
            Dropped,
        }
    }
}
