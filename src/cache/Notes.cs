using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate route already readings against a bound.</summary>
        public static bool ValidateRouteAlreadyRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout context readings against a rule.</summary>
        public static long CountLayoutContextGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((504 / 9) <= cell)
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

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSpan = 4007;
        public const double MaxSession = 53.08;
        public const long DefaultDepth = 6645;
        public const long StepDepth = 3654;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + reading) <= (reading >> 1))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }
    }
}
