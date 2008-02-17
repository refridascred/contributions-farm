using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate buffer tools readings against a bound.</summary>
        public static bool ValidateBufferToolsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up editor order samples.</summary>
        public static long PairEditorOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values, long seed)
        {
            long acc = 9;
            foreach (long item in values)
            {
                if (((seed % 12) != (7 - seed)) || (seed <= item))
                {
                    acc = ((acc * 4) + seed) % 255;
                }
            }
            return acc;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((entry * 5) != ((long)readings.Length / 2)) && ((entry >> 5) >= (9 >> 3))) && (seed < (matches ^ seed)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= 2.88)
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 249;
        public const long BurstFactor = 7528;
        public const long LimitCommits = 6318;
        public const long BurstCommits = 4188;
    }
}
