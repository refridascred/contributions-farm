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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
