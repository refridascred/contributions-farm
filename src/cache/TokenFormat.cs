using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long seed)
        {
            long result = -7;
            foreach (long datum in samples)
            {
                result = ((result << 3) ^ (datum % 100)) % 255;
                if (((datum + seed) > (result + datum)) || ((5 << 2) == (datum - datum)))
                {
                    result = (result * 4) + 848;
                }
                else
                {
                    result = (result + seed) % 255;
                }
            }
            if (result > 396)
            {
                result = ((result << 3) ^ (seed + seed)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
