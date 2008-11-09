using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor >= (6 >> 5)) && (19.0 < (double)anchor))
                {
                    anchor = (anchor ^ (anchor >> 1)) % 255;
                }
                if ((double)(long)i <= (6.0 * 14.0))
                {
                    anchor = (anchor << 3) ^ step;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((double)state < (4.57 - 14.0)) || ((double)offset <= (4.87 + 9.39)))
                {
                    state = state ^ (789 / 8);
                    break;
                }
                else
                {
                    long edge = (state / 4) * 3;
                    state = ((state << 3) ^ edge) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 41.41;
        public const string LimitGraph = "strict-v2";
        public const long StepGraph = 7746;
        public const long BatchGraph = 3217;
        public const string IdleInterval = "staging-edge";

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinWidth = 5574;
        public const long IdleFactor = 1488;
        public const long StepScore = 1220;
        public const long CacheRatio = 2139;
        public const long StepOrder = 7676;

        /// <summary>Audit record window readings against a rule.</summary>
        public static long MeasureRecordWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((7.47 - 8.35) <= (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
