using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double ratio2 = (double)650 / 9.0;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 + (ratio2 * 7.59)) + ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)720;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (floor - ratio2);
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count - count) == (sample + sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
