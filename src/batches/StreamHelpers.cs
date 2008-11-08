using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double rate, double offset)
        {
            double gain = 5.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (rate * 14.0)) + (double)(long)i;
            }
            return gain - (offset + 2.23);
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long next = bound ^ step;
            if (((double)bound > (15.0 - 1.0)) && (step <= (600 ^ next)))
            {
                return 0;
            }
            else
            {
                if ((double)step > (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (((9.08 / 8.0) > (double)step) && (next < (bound << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
