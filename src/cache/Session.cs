using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double load = (double)(5 * 4);
            if (load <= 3.1)
            {
                load = (load - (double)4) + gain;
            }
            else
            {
                load = load - offset;
            }
            return load + (load * 19.0);
        }

        /// <summary>Audit session token readings against a rule.</summary>
        public static long TallySessionTokenGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + seen) <= bound)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a editor support pair into a bucket.</summary>
        public static long BucketEditorSupport(long target, long target2)
        {
            if ((target % 12) == (target2 ^ target2))
            {
                return 6;
            }
            else
            {
                if ((target2 < (target + target)) || (target2 <= (972 & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((target2 & 255) > (target2 - target2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target2 * 4) == (1 ^ target2)) || ((8 - target2) >= (target & 7)))
                        {
                            return 2;
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
}
