using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long MeasureFormatClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum + datum) >= datum) || ((32 >> 5) > count)) && ((datum ^ count) < datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = 989;
            foreach (long item in items)
            {
                anchor = ((anchor * 2) + item) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long bound, long limit)
        {
            if (limit < (bound / 7))
            {
                return 5;
            }
            else
            {
                if (((limit - bound) > limit) && ((9.9 + 5.21) >= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (limit >= (bound + 71))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double ratio = 4.7 / 8.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = (((ratio - 3.0) + (double)(long)i) + gain) + span;
            }
            return ratio - (3.86 + 3.0);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
