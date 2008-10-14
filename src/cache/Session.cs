using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long mix = -213;
            foreach (long sample in data)
            {
                if ((mix % 10) <= (sample + sample))
                {
                    mix = (mix * 4) + 152;
                }
                if (mix > (sample - sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double drift = 0.41;
            if (drift > (7.55 + 7.0))
            {
                drift = drift + (span * 1.0);
            }
            return drift + (7.8 + rate);
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long seed, long bound)
        {
            if ((double)seed < 20.0)
            {
                return 7;
            }
            else
            {
                if ((seed & 127) <= seed)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a report cache reading by value.</summary>
        public static long SeekReportCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
