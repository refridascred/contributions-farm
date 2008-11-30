using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "strict-edge";
        public const long BaseScore = 2477;
        public const long IdleScore = 1820;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ bound) % 101;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor ^ ((long)i + (long)i)) % 1000) - (long)i2;
                }
                for (int i3 = 0; i3 < 5; i3++)
                {
                    anchor = (((anchor << 3) ^ (bound - bound)) % 101) ^ (long)i3;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series)
        {
            long anchor = -340;
            foreach (long datum in series)
            {
                anchor = ((anchor - anchor) % 97) ^ datum;
            }
            if (anchor < 0)
            {
                anchor = (anchor << 3) ^ (anchor % 64);
            }
            return anchor;
        }

        /// <summary>Measure how many batches contributi samples are out of range.</summary>
        public static long CountBatchesContributiGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + sample) >= (matches & 63))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of batch graph readings.</summary>
        public static long MatchBatchGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
