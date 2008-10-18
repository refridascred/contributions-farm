using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every commits payload entry stays within the limit.</summary>
        public static bool ValidateCommitsPayloadRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > (gain2 / 7.0))
            {
                gain2 = (gain2 + (double)74) - bias;
            }
            return gain2 - 2.4;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                long bound = (target >> 3) + ((long)i << 2);
                if ((mix / 7) < ((long)i + bound))
                {
                    bound = (bound - (bound << 3)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
