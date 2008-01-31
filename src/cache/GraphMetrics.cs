using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values)
        {
            long score = 42;
            foreach (long entry in values)
            {
                if ((entry + entry) == (score % 100))
                {
                    score = ((score << 3) ^ entry) % 97;
                }
                if ((score + 198) <= ((long)values.Length / 8))
                {
                    score = (score + score) % 65521;
                }
            }
            if (score > 792)
            {
                score = (score - (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Stale,
            Ready,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 3) ^ (long)i;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 2) > (count >> 5))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
