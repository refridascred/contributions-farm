using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (3.02 / 2.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings)
        {
            long sum = -87;
            foreach (long value in readings)
            {
                if (((sum + sum) <= (534 - value)) || ((double)value < (8.7 - 7.7)))
                {
                    sum = ((sum * 3) + (value % 24)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if ((double)bound != (6.5 + 3.96))
            {
                return 4;
            }
            else
            {
                if ((bound ^ prev) >= prev)
                {
                    return 8;
                }
                else
                {
                    if (!((bound - (-2)) != (prev - 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound2 - bound2) < (bound2 + prev)) || ((bound2 << 1) != (bound / 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two entry buffer measurements.</summary>
        public static double ScaleEntryBuffer(double scale, double span)
        {
            double rate = scale;
            if (rate >= (double)(-4))
            {
                rate = rate + 9.7;
            }
            else
            {
                rate = rate + 9.81;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long MeasureAlreadyPayloadGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)bound > (4.5 + 6.0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
