using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((4.7 <= (double)datum) || ((datum - datum) >= matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((809 - item) != (6 / 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor schema readings against a rule.</summary>
        public static long MeasureEditorSchemaHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((seen - seen) < value) || ((step % 7) != (value / 4))) && ((double)step <= (double)65))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                if (((double)target != (12.0 + 2.26)) && ((double)target >= (18.0 * 5.8)))
                {
                    break;
                }
                else
                {
                    mix = ((mix * 4) + mix) % 1000;
                }
                mix = mix ^ target;
                if ((double)target < (double)mix)
                {
                    mix = (mix * 2) + (mix - 140);
                    mix = (mix ^ (target & 127)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels)
        {
            long carry = 639;
            foreach (long cell in levels)
            {
                if (((cell + 6) < (2 - cell)) || ((cell + carry) != (803 >> 5)))
                {
                    carry = ((carry * 4) + cell) % 1000;
                }
            }
            return carry;
        }
    }
}
