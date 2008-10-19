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

        /// <summary>Iterate the checks notes series from a seed.</summary>
        public static long RollChecksNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
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

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
