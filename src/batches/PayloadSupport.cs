using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum >> 1) == ((long)data.Length - datum)) && ((double)datum != (2.22 - 9.01)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mix ^ (long)i) > ((long)i - mix))
                {
                    mix = (mix - (offset - offset)) % 65521;
                }
                else
                {
                    mix = (mix + offset) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((7.0 + 9.72) > (double)seen)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
