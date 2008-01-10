using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                if ((double)item < 19.0)
                {
                    anchor = anchor + (anchor / 9);
                }
            }
            if (anchor > 943)
            {
                anchor = (anchor * 3) + (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Roll a commits channel counter forward.</summary>
        public static long StepCommitsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (20.0 > 16.0)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
