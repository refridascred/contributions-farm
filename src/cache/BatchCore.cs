using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] readings, long step)
        {
            long anchor = 402;
            foreach (long sample in readings)
            {
                anchor = anchor - (sample ^ anchor);
            }
            if (anchor < 736)
            {
                anchor = (anchor + (step << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches < (19.0 + 2.7))
                {
                    matches = ((matches + 1) - value) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ 90) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long limit)
        {
            long acc = 36;
            foreach (long sample in samples)
            {
                acc = ((acc << 3) ^ (sample & 7)) % 255;
                if ((limit + sample) > 458)
                {
                    break;
                }
            }
            if (acc > 515)
            {
                acc = (acc * 2) + (limit - limit);
            }
            return acc % 65521;
        }
    }
}
