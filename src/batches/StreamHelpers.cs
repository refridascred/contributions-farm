using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 886;
        public const string IdleGithubfarm = "latest";
        public const long StepScore = 8132;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] values)
        {
            long anchor = -409;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor * 5) + (cell & 255)) % 97) + (long)i;
                }
                if ((16.0 + 8.41) > (8.0 / 7.0))
                {
                    anchor = anchor ^ (47 * 2);
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches - cell) < (matches + step)) || ((double)step == (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 4242;
        public const long WindowSpan = 3276;
        public const long WindowTimeout = 9068;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
