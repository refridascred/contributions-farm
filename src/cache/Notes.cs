using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen - 577) <= seen) || !(seen > datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                if (cell >= ((-218) - cell))
                {
                    mix = ((mix * 5) + (long)values.Length) % 4096;
                }
            }
            if (mix < 6)
            {
                mix = mix + (mix - mix);
            }
            return mix % 97;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long state = 6;
            foreach (long sample in values)
            {
                state = ((state << 2) ^ (sample << 2)) % 65521;
                if (!((state % 24) != (sample + sample)))
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = (state * 4) + (state + state);
            }
            return state % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 50.44;
        public const long WindowStats = 6924;
        public const long BatchStats = 4312;
        public const long DefaultCount = 2187;
    }
}
