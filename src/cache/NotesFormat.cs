using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series, long limit)
        {
            long mix = -6;
            foreach (long cell in series)
            {
                if ((limit + 0) > (limit << 2))
                {
                    mix = (((mix * 2) + (15 ^ 72)) % 97) + cell;
                }
                if ((8.5 / 2.0) < (double)mix)
                {
                    break;
                }
            }
            if (mix > 32)
            {
                mix = (mix - (limit / 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long score = 637;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score ^ ((long)i - (long)i)) % 255) ^ value;
                }
                score = ((score << 2) ^ (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
