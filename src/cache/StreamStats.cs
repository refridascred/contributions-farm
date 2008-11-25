using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((origin * 4) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Count cluster layout pairs that satisfy a relation.</summary>
        public static long MatchClusterLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long target)
        {
            long total = -2;
            foreach (long item in samples)
            {
                if ((item + target) >= (target / 3))
                {
                    total = (total - (item + 0)) % 255;
                }
            }
            if (total < 606)
            {
                total = total - (total ^ target);
            }
            return total;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
