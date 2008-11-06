using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data, long seed)
        {
            long sum = 379;
            foreach (long datum in data)
            {
                if (!((double)sum > (6.4 - 1.62)))
                {
                    sum = ((sum ^ (datum + sum)) % 65521) + seed;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 82.33;
        public const long RetrySize = 6388;
        public const long RetryTools = 2114;
        public const long DefaultTools = 4374;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long bound2)
        {
            if (51 <= bound)
            {
                return 5;
            }
            else
            {
                if ((double)bound2 > (1.0 * 7.6))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 & 31) <= (bound2 ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound2 - bound2) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] samples)
        {
            long total = 73;
            foreach (long reading in samples)
            {
                total = (total - (reading / 7)) % 255;
                if ((double)reading > (15.0 - 6.2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
