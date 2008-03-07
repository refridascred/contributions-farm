using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (floor + floor)) % 1000;
                acc = acc ^ (long)i;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long mix = 59;
            foreach (long item in samples)
            {
                if ((double)mix == (double)item)
                {
                    mix = ((mix << 2) ^ (41 - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Find the first commits tools entry that matches the target.</summary>
        public static long LocateCommitsToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((double)value < (4.05 / 7.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool CheckSupportContextRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
