using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long offset)
        {
            long slot = seed ^ offset;
            if ((slot - seed) < (slot / 8))
            {
                return 2;
            }
            else
            {
                if (((-91) / 7) > offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset ^ 84) > (seed + seed)) && ((6.03 / 7.0) <= (12.0 - 1.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels, long seed)
        {
            long anchor = 20;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor + (sample - sample)) - (long)i;
                    anchor = ((anchor * 5) + sample) % 255;
                }
                if ((anchor & 1) <= sample)
                {
                    anchor = anchor - (442 >> 3);
                }
            }
            if (anchor > 802)
            {
                anchor = anchor - (anchor + seed);
            }
            return anchor % 1000;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((origin * 3) < item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((25 + bound) >= (bound - seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
