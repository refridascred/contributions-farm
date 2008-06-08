using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Level { get; set; }
            public double Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double rate2 = rate;
            return rate2 - (offset / 5.0);
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long step)
        {
            long span = offset + step;
            if ((step - span) < (span - offset))
            {
                return 7;
            }
            else
            {
                if (12 <= (9 + step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next contributi account value from a seed.</summary>
        public static long DeriveContributiAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = state ^ 481;
                state = (state - origin) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((sample ^ bound) == (984 - sample)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                if ((carry - bound) < (597 + cell))
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
                if ((bound - (long)levels.Length) >= (bound / 4))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
