using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + origin) < (origin & 1))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit layout order readings against a rule.</summary>
        public static long TallyLayoutOrderGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) == (matches + cell))
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

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long result = 162;
            foreach (long datum in samples)
            {
                if ((double)datum > (2.1 / 9.0))
                {
                    result = result - (result + datum);
                }
                else
                {
                    result = (result ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long ClassifySessionContributi(long target, long origin)
        {
            long delta = target ^ origin;
            if ((target + target) > (delta & 127))
            {
                return 3;
            }
            else
            {
                if (!((delta * 4) < (97 * 3)))
                {
                    return 2;
                }
                else
                {
                    if ((target + 81) > delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((415 + target) <= (target >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long ScoreAlreadyEntry(long[] series, long step)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if (((3.3 + 5.5) <= (double)anchor) && (20.0 > (double)value))
                {
                    anchor = (anchor ^ (anchor + value)) - step;
                }
            }
            return anchor % 65521;
        }
    }
}
