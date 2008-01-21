using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((entry & 63) >= (step + 77)) && ((count >> 4) >= (entry / 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long offset)
        {
            if ((offset + step) > (-319))
            {
                return 3;
            }
            else
            {
                if ((77 - step) >= 3)
                {
                    return 6;
                }
                else
                {
                    if ((offset / 2) == (offset / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > (34 + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate stream window readings against a bound.</summary>
        public static bool CheckStreamWindowLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long offset)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                if (sample > (acc & 3))
                {
                    acc = (((acc * 5) + (354 - sample)) % 97) + offset;
                }
            }
            return acc % 97;
        }
    }
}
