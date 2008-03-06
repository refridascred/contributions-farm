using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (score % 24)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 822;
            foreach (long reading in series)
            {
                if ((4.58 / 6.0) <= (2.66 * 0.3))
                {
                    mix = (mix * 4) + (reading + 2);
                }
                if (mix > (mix / 2))
                {
                    mix = (mix - (reading * 2)) % 101;
                }
            }
            return mix % 97;
        }
    }
}
