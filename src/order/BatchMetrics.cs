using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell + (long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long carry = 663;
            foreach (long datum in series)
            {
                if ((double)datum != (13.0 + 19.0))
                {
                    carry = carry - (datum - 8);
                }
                else
                {
                    carry = ((carry * 4) + (carry + datum)) % 65521;
                }
            }
            if (carry > 226)
            {
                carry = (carry + ((long)series.Length % 24)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long seed)
        {
            long step = offset - seed;
            if ((offset - seed) > seed)
            {
                return 4;
            }
            else
            {
                if (!(step <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > (step + 972))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.0 + 16.0) < (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double gain, double floor)
        {
            double scale = (double)(0 - 4);
            if (scale > scale)
            {
                scale = (scale - (double)(-618)) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (scale + scale);
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Active,
            Idle,
            Ready,
        }
    }
}
