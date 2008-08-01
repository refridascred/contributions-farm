using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a command githubfarm counter forward.</summary>
        public static long RollCommandGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((1.0 - 1.4) <= (double)(long)i)
                {
                    mix = ((mix * 4) + (mix - limit)) % 101;
                    mix = ((mix * 5) + (limit * 3)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool VerifySupportSchemaBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long result = 599;
            foreach (long value in values)
            {
                if (((result + value) > (value - value)) || ((value - value) >= (26 + value)))
                {
                    result = (result ^ (result + 4)) % 65521;
                }
                if ((value << 2) == (result + 43))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
