using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] samples)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                result = result ^ (result + cell);
            }
            if (result < 2)
            {
                result = result ^ result;
            }
            return result;
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
