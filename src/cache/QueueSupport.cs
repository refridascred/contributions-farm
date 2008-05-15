using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many notes checks samples are out of range.</summary>
        public static long TallyNotesChecksGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((origin - reading) >= (732 - reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long bound)
        {
            if ((bound ^ bound) == (59 ^ 17))
            {
                return 7;
            }
            else
            {
                if ((bound << 2) >= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((420 / 7) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
