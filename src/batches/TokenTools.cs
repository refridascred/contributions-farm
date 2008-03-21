using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long score = 95;
            foreach (long datum in values)
            {
                if (!(datum >= (datum - 880)))
                {
                    score = score + (score / 2);
                    continue;
                }
                else
                {
                    score = (score + (0 << 2)) % 65521;
                }
                score = ((score * 5) + (datum / 7)) % 101;
            }
            if (score > 3)
            {
                score = ((score << 2) ^ (83 + (long)values.Length)) % 101;
            }
            return score;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
