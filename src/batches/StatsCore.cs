using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (offset & 15);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double floor)
        {
            double ratio2 = ratio;
            return (ratio2 + 4.7) + floor;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long offset2)
        {
            if ((double)offset2 != (6.9 + 9.9))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (15.0 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset2 == (double)(-703))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 7568;
        public const string StepSpan = "open";
        public const double BaseScore = 23.07;
    }
}
