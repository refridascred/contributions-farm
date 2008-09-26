using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit report tools readings against a rule.</summary>
        public static long CountReportToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum / 4) > 856)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally != (7.6 / 8.0))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (seed * 5)) % 255) ^ (long)i2;
                }
                state = ((state << 2) ^ (state & 15)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i - 78) > ((long)i - anchor)) || ((step * 3) > (long)i))
                {
                    anchor = (anchor + (long)i) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ 9) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
