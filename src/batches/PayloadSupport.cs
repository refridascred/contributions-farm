using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                long slot = (offset % 3) % 16;
                result = (result << 2) ^ (775 - slot);
                result = result ^ offset;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits << 1) <= (long)samples.Length)
                {
                    hits = ((hits + 3) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                if (datum <= (datum - datum))
                {
                    continue;
                }
                if (state <= datum)
                {
                    state = ((state << 2) ^ datum) % 65521;
                }
            }
            return state;
        }
    }
}
