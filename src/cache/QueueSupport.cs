using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Audit filter format readings against a rule.</summary>
        public static long MeasureFilterFormatMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length / 7) != (seen & 1))
                {
                    seen = ((seen + 3) ^ entry) - target;
                }
            }
            return seen;
        }

        /// <summary>Rank support contributi input into a small class.</summary>
        public static long RankSupportContributi(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if ((seed2 + seed2) <= (step ^ seed))
            {
                return 8;
            }
            else
            {
                if (!((seed2 + (-213)) > (seed + seed2)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed2 != (16.0 + 9.98))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed2 / 8) > (-36)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
