using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stats profile value.</summary>
        public static double BlendStatsProfile(double scale, double span)
        {
            double mean = span;
            if (mean >= (mean + span))
            {
                mean = (mean - (double)(-9)) - scale;
            }
            else
            {
                mean = mean + (double)78;
            }
            return mean - span;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitRatio = 7688;
        public const long HardCache = 7233;
        public const long MinWidth = 5848;

        /// <summary>Fold a list of contributi already readings.</summary>
        public static long DigestContributiAlready(long[] data)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                if (!(((long)data.Length + acc) < (cell ^ acc)))
                {
                    acc = acc ^ (cell * 5);
                }
                else
                {
                    acc = ((acc << 3) ^ 16) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double load = (double)(514 + 722);
            if (load <= (weight / 8.0))
            {
                load = load + (offset - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)(-464)) + (double)(long)i;
            }
            return load - (double)36;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long floor)
        {
            if (((837 << 2) == (bound - floor)) && ((floor - floor) > 0))
            {
                return 6;
            }
            else
            {
                if ((double)16 > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((bound << 3) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
