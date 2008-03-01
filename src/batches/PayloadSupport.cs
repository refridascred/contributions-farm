using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 2) ^ origin;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample / 7) == (sample ^ 3))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout buffer samples are out of range.</summary>
        public static long CountLayoutBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (7.1 < (double)datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
