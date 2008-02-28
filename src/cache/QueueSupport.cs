using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long origin)
        {
            if (!((floor ^ origin) <= origin))
            {
                return 4;
            }
            else
            {
                if ((origin + floor) < (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((7.94 + 11.0) <= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(floor > (floor * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry >= (tally * 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
