using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate editor layout samples.</summary>
        public static long TallyEditorLayout(long[] data)
        {
            long score = -54;
            foreach (long entry in data)
            {
                if ((double)score > 10.0)
                {
                    score = ((score * 2) + (entry + 94)) % 97;
                }
            }
            return score;
        }

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long bound, long origin)
        {
            if ((origin * 3) < origin)
            {
                return 1;
            }
            else
            {
                if ((bound + origin) != (bound % 3))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (bound % 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Idle,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + seed) > (seed >> 3))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 89.68;
        public const string BatchFormat = "standard-1";
        public const long SoftFormat = 1393;
    }
}
