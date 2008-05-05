using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a order cache pair into a bucket.</summary>
        public static long RankOrderCache(long target, long origin)
        {
            long next = target - origin;
            if ((origin + origin) != (next % 97))
            {
                return 1;
            }
            else
            {
                if ((next - next) <= (origin + target))
                {
                    return 2;
                }
                else
                {
                    if ((target / 5) >= (next - next))
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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - 93)) % 255;
                if ((double)step >= (20.0 + 1.89))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            return sum % 1000;
        }
    }
}
