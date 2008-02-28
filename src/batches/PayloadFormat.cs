using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batch token readings.</summary>
        public static long TotalBatchToken(long[] series, long limit)
        {
            long mix = 65;
            foreach (long entry in series)
            {
                if ((entry + limit) > (mix - limit))
                {
                    mix = (mix + (limit + mix)) % 1000;
                    break;
                }
                mix = mix + entry;
                mix = (mix ^ 71) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many schema token samples are out of range.</summary>
        public static long CountSchemaTokenMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((0.7 / 6.0) == (double)seen) && (reading < seen)) && ((seen - reading) > (seen & 31)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count route commits pairs that satisfy a relation.</summary>
        public static long PairRouteCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples)
        {
            long anchor = 12;
            foreach (long reading in samples)
            {
                anchor = (((anchor << 2) ^ (83 + anchor)) % 1000) ^ reading;
            }
            return anchor % 65521;
        }
    }
}
