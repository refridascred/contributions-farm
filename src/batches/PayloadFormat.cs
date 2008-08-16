using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit record graph readings against a rule.</summary>
        public static long CountRecordGraphHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally / 2) < 23)
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long MeasurePayloadGithubfarmOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((8.26 * 7.0) >= (double)step))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((99 & 3) < (matches + matches))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
