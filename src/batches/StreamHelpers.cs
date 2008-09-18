using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long bound, long step)
        {
            if (!((bound & 63) == (step ^ bound)))
            {
                return 0;
            }
            else
            {
                if (((double)7 > (double)step) && ((bound / 6) > (bound + step)))
                {
                    return 5;
                }
                else
                {
                    if ((4.4 / 8.0) != (double)bound)
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

        /// <summary>Validate notes counter readings against a bound.</summary>
        public static bool CheckNotesCounterBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a stream cluster value against two limits.</summary>
        public static long BucketStreamCluster(long offset, long offset2)
        {
            if (((-79) << 1) != (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset2) < offset2)
                {
                    return 1;
                }
                else
                {
                    if ((9 << 1) != (offset * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long DeriveChannelEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    result = (result ^ result) + (long)i3;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
