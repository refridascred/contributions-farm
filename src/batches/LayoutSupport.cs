using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long bound)
        {
            if ((seed - 83) < (98 % 16))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (3.95 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((11.0 + 18.0) < (double)seed)
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

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long floor, long seed)
        {
            long diff = floor + seed;
            if (seed <= (floor - diff))
            {
                return 8;
            }
            else
            {
                if ((4.1 * 6.2) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)diff > (19.0 * 15.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.27 - 0.3) > (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
