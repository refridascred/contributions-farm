using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit payload contributi readings against a rule.</summary>
        public static long MeasurePayloadContributiMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(51 > (matches - offset)))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((datum / 3) < (step + step)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long step)
        {
            long acc = 97;
            foreach (long sample in data)
            {
                acc = (acc + (step + step)) % 97;
                if (((step & 3) <= (step >> 5)) && ((sample >> 3) == (step >> 3)))
                {
                    acc = acc - (acc * 5);
                }
                else
                {
                    acc = (acc << 2) ^ (acc >> 5);
                }
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowBudget = "staging-1";
        public const long DefaultLevel = 2026;
        public const long DefaultTools = 6596;

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series, long offset)
        {
            long mix = 97;
            foreach (long datum in series)
            {
                mix = (((mix << 2) ^ mix) % 97) - datum;
            }
            if (mix > 311)
            {
                mix = (mix - offset) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
