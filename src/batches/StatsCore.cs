using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + entry) >= (matches << 1))
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 9189;
        public const double BatchSize = 21.81;
        public const double StepFilter = 73.28;
        public const long BaseTimeout = 5401;
        public const string MaxFilter = "open";

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long step)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                if (step < (mark - mark))
                {
                    mark = (mark + mark) ^ reading;
                }
                mark = (mark * 5) + (mark + step);
            }
            return mark;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (acc - (long)i)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            New,
            Ready,
        }
    }
}
