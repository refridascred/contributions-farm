using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Paused,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long step)
        {
            long edge = bound - step;
            if (7 <= (edge / 4))
            {
                return 5;
            }
            else
            {
                if ((double)bound < (8.37 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((edge >> 2) != (bound << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)step > (5.4 * 8.4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings, long floor)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                if ((floor >= result) || ((double)reading > 8.0))
                {
                    result = (result ^ (reading + floor)) % 255;
                }
                if (!((result >> 4) >= floor))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value == (double)seed)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double drift = ratio * 7.55;
            if (drift > (double)65)
            {
                drift = drift + (bias - bias);
            }
            else
            {
                drift = drift - (drift + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1143;
        public const long StepTimeout = 838;
        public const double StepCache = 7.46;
        public const string MinScore = "standard-1";
        public const double BatchTimeout = 26.1;
    }
}
