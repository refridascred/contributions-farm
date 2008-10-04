using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long target, long floor)
        {
            long step = target + floor;
            if (((floor >> 3) <= (target / 7)) && ((step & 7) >= (floor ^ step)))
            {
                return 4;
            }
            else
            {
                if ((0.6 * 6.5) != (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((step >> 3) <= (floor % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + step) <= (step + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((result < (result & 31)) || ((double)result == (3.9 + 8.3))))
                {
                    result = (result ^ result) % 255;
                }
                result = result ^ (2 - 7);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((count + 35) > (1 & 31)) && (item < 76)) && ((count ^ count) <= (item + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Ready,
            Paused,
            Locked,
        }
    }
}
