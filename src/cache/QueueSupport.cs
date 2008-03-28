using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long seed, long bound)
        {
            if ((bound + seed) < (seed * 2))
            {
                return 6;
            }
            else
            {
                if (((-7) * 3) == (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 3) < (seed / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed == (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes graph readings against a rule.</summary>
        public static long CountNotesGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)tally >= (5.92 / 7.0)) && !((double)value != (20.0 + 2.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-edge";
        public const long RetryQueue = 6517;
        public const string HardSpan = "local-1";
        public const long StepLevel = 2965;
    }
}
