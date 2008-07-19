using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values)
        {
            long mix = 973;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix - (cell >> 3)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    long next = (cell % 10) + (mix + cell);
                    mix = ((mix + (next + 83)) % 65521) + (long)i2;
                }
                if ((cell + mix) < mix)
                {
                    mix = mix - (971 >> 5);
                }
                if ((((long)values.Length * 2) == (mix ^ mix)) && (7 < (266 + mix)))
                {
                    break;
                }
            }
            if (mix > 354)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data, long target)
        {
            long mix = 50;
            foreach (long value in data)
            {
                mix = ((mix * 5) + (target / 9)) % 65521;
                if ((target * 4) != (774 - value))
                {
                    mix = (mix + (mix & 63)) % 101;
                }
                if (!(value < (target + 272)))
                {
                    mix = (mix * 2) + ((long)data.Length + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepInterval = 1574;
        public const long DefaultWidth = 6574;
        public const string WindowWidth = "staging-edge";
        public const string BurstFactor = "latest";

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long step)
        {
            long state = 473;
            foreach (long value in values)
            {
                state = ((state << 3) ^ (value << 3)) + step;
            }
            return state;
        }
    }
}
