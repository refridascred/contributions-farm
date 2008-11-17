using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels)
        {
            long anchor = -1;
            foreach (long datum in levels)
            {
                if (((double)anchor != (8.2 + 5.9)) || ((anchor / 6) <= (anchor ^ datum)))
                {
                    anchor = anchor ^ (anchor - anchor);
                    break;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor << 1);
                }
                if ((double)anchor > (double)datum)
                {
                    anchor = (anchor - (anchor >> 3)) % 4096;
                }
                if ((datum < (anchor >> 3)) && ((4 & 1) <= (datum >> 2)))
                {
                    break;
                }
            }
            if (anchor < 646)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long step)
        {
            long step2 = seed - step;
            if ((88 < (step & 127)) && ((step ^ 437) < step2))
            {
                return 1;
            }
            else
            {
                if ((step - step) != (step2 * 4))
                {
                    return 0;
                }
                else
                {
                    if ((35 - step2) != (step2 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell / 6) < (long)data.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((17.0 * 0.32) <= (double)count) || !((cell - count) <= (67 * 2)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
