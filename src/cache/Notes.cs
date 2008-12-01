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

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Failed,
            Dropped,
            Idle,
            Retry,
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

        /// <summary>Count stream layout pairs that satisfy a relation.</summary>
        public static long OverlapStreamLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
