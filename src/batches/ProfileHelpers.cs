using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((85 + value) < ((long)levels.Length - seen)) || (((seen << 3) >= (seen - 49)) && ((value & 63) < (value - seen))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long target, long origin)
        {
            long next = target ^ origin;
            if ((((-35) << 3) < (origin % 8)) && ((origin % 3) < origin))
            {
                return 2;
            }
            else
            {
                if (!((double)next > (double)target))
                {
                    return 4;
                }
                else
                {
                    if (!((13.0 / 9.0) < (double)next))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((8.0 * 9.3) == (double)next) || ((target + 502) > (818 + target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double mean = floor;
            if (mean < rate)
            {
                mean = mean + (double)70;
            }
            else
            {
                mean = mean + (floor / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Done,
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double drift = bias;
            if (drift > bias)
            {
                drift = (drift + (drift + 9.5)) - offset;
            }
            return drift + (double)8;
        }
    }
}
