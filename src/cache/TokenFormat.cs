using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long result = 146;
            foreach (long datum in levels)
            {
                if (!((double)result <= (1.0 - 2.4)))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = (result << 3) ^ (datum - result);
                }
                if (datum >= result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long step)
        {
            long edge = offset ^ step;
            if (((offset + step) >= (step / 3)) && (edge < offset))
            {
                return 2;
            }
            else
            {
                if ((double)step > (4.4 + 18.0))
                {
                    return 1;
                }
                else
                {
                    if ((step & 3) > (edge - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
