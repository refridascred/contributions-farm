using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((step << 3) <= (entry % 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (step / 6)) % 4096) ^ (long)i2;
                    score = ((score * 2) + (4 ^ score)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchCount = 1267;
        public const double SoftDepth = 20.36;
        public const long WindowTimeout = 4602;
        public const double BaseContributi = 25.96;
        public const long IdleContributi = 8534;

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 2) + (step >> 2);
                score = score ^ (step + step);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
