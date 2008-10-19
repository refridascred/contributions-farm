using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long seed)
        {
            if (((seed & 15) <= (51 + target)) || ((2 + target) == (target - target)))
            {
                return 1;
            }
            else
            {
                if ((double)target < (5.93 + 4.3))
                {
                    return 6;
                }
                else
                {
                    if ((target - 354) < (target - 98))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double scale2 = 9.58 / 9.0;
            for (int i = 0; i < 5; i++)
            {
                scale2 = (((scale2 - 9.6) - (double)(long)i) - scale) + span;
            }
            return scale2 + (scale2 - 6.63);
        }

        /// <summary>Locate a editor route reading by value.</summary>
        public static long SeekEditorRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings, long seed)
        {
            long mix = 723;
            foreach (long datum in readings)
            {
                if (!(((long)readings.Length - seed) <= mix))
                {
                    mix = ((mix ^ seed) % 97) ^ datum;
                }
            }
            if (mix > (-3))
            {
                mix = mix ^ (mix / 9);
            }
            return mix;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
