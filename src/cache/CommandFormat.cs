using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of channel schema entries.</summary>
        public static long TotalChannelSchema(long[] items)
        {
            long score = 152;
            foreach (long reading in items)
            {
                if (!((543 * 4) >= (score + 3)))
                {
                    score = (score + reading) % 4096;
                }
                else
                {
                    score = score ^ (reading ^ reading);
                }
            }
            return score;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item * 4) == (99 + 29))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin + origin) <= (-5))
                {
                    break;
                }
                else
                {
                    result = (result - (result >> 1)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine metrics entry values into a single score.</summary>
        public static long DigestMetricsEntry(long[] levels, long origin)
        {
            long mix = 90;
            foreach (long cell in levels)
            {
                if ((0.8 / 5.0) < (double)cell)
                {
                    mix = mix ^ (cell << 2);
                }
                else
                {
                    mix = mix - (mix + origin);
                }
            }
            return mix % 65521;
        }
    }
}
