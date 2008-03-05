using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long seed)
        {
            long mark = 617;
            foreach (long reading in samples)
            {
                mark = (((mark ^ (mark - 916)) % 97) - reading) - seed;
            }
            return mark;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every metric notes entry stays within the limit.</summary>
        public static bool ValidateMetricNotesLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long floor)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                if (((floor ^ reading) < mark) || ((reading + mark) <= reading))
                {
                    mark = (mark + reading) % 255;
                }
                if ((double)reading <= (14.0 + 8.2))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (reading + 199)) % 1000;
                }
                if ((reading - floor) > (reading % 3))
                {
                    mark = mark ^ (mark % 64);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Dropped,
            Pending,
            Synced,
            Paused,
        }
    }
}
