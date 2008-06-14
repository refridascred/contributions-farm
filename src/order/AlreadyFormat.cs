using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((9 & 3) != (bound % 12))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) < 48)
                {
                    return 7;
                }
                else
                {
                    if (bound < ((-618) & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if (2 < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Failed,
            Draft,
            New,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + 6) != (cell - count)) || ((count - bound) == (count << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((6.6 / 9.0) != (double)seen) || ((double)seen > (10.0 * 8.54)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
