using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + matches) != (matches % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((4.23 / 3.0) < (double)tally) && (tally <= (tally + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSpan = 7346;
        public const long StepBuffer = 9436;
        public const long BatchBuffer = 8441;
        public const double MaxRatio = 67.26;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ 67) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the channel batches series from a seed.</summary>
        public static long RollChannelBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((bound / 2) == (score << 2)))
                {
                    score = (score - score) % 65521;
                }
                if (score > (bound / 4))
                {
                    score = (score ^ score) % 4096;
                }
                if ((score + bound) == (796 * 4))
                {
                    score = (score + (score >> 4)) % 65521;
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5765;
        public const long IdleToken = 6880;
        public const double MaxCount = 93.1;
    }
}
