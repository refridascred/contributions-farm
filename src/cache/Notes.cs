using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 2259;
        public const double RetryRecord = 53.12;
        public const long WindowRecord = 8364;

        /// <summary>Derive the next schema report value from a seed.</summary>
        public static long DeriveSchemaReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if (offset >= (offset - offset))
                {
                    long count = 8;
                    sum = (sum << 3) ^ (count & 31);
                }
                else
                {
                    sum = sum ^ sum;
                }
                if (offset >= 12)
                {
                    sum = sum ^ (offset << 1);
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = (state << 2) ^ (state % 16);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (6.8 >= (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
