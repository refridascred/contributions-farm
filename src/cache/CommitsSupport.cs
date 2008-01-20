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

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long total = 325;
            foreach (long entry in samples)
            {
                total = ((total << 3) ^ (entry - entry)) % 1000;
                if (entry > (total - total))
                {
                    total = (total ^ (total >> 3)) % 97;
                }
                total = total - (7 + entry);
                if ((total + entry) == (total * 4))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = total - (total + total);
            }
            return total;
        }

        /// <summary>Compare every pair of tools account readings.</summary>
        public static long MatchToolsAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5765;
        public const long IdleToken = 6880;
        public const double MaxCount = 93.1;
    }
}
