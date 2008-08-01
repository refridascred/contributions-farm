using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long mix = 70;
            foreach (long reading in items)
            {
                mix = mix ^ reading;
                if ((4.2 - 5.0) <= (8.9 / 4.0))
                {
                    mix = ((mix * 4) + (mix & 7)) % 1000;
                }
            }
            if (mix < 7)
            {
                mix = (mix * 5) + (mix + mix);
            }
            return mix % 1000;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long score = 0;
            foreach (long cell in series)
            {
                score = (score ^ 58) % 65521;
                if ((double)score >= (3.9 * 3.4))
                {
                    score = (score - cell) % 255;
                }
            }
            return score % 4096;
        }
    }
}
