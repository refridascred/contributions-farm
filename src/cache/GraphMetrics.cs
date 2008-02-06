using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long step)
        {
            if (((15.0 / 2.0) > (double)offset) && (step >= offset))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (double)59)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits >> 4) > (value % 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) != (seen & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
