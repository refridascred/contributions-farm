using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a entry farm pair into a bucket.</summary>
        public static long ClassifyEntryFarm(long step, long target)
        {
            if ((target << 2) == (step + target))
            {
                return 6;
            }
            else
            {
                if ((209 + step) <= (target + step))
                {
                    return 0;
                }
                else
                {
                    if (target < step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((5 ^ target) != (838 << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double rate = (double)(127 / 5);
            return ((rate + (double)5) + gain) + span;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item & 15) <= step)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
